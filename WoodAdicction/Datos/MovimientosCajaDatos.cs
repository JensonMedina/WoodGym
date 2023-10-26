using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class MovimientosCajaDatos
    {
        public List<MovimientosCaja> listarMovimientosConSp()
        {
            List<MovimientosCaja> listaMovimientos = new List<MovimientosCaja>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearStoredProcedure("storedListarMovimientosCaja");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    MovimientosCaja aux = new MovimientosCaja();
                    aux.TransaccionId = (int)datos.lector["transaccionId"];
                    aux.Fecha = (DateTime)datos.lector["fecha"];
                    aux.Descripcion = datos.lector["descripcion"] is DBNull ? "Sin descripcion" : (string)datos.lector["descripcion"];
                    aux.Monto = (decimal)datos.lector["monto"];
                    aux.MetodoPago = new MetodosPago();
                    aux.MetodoPago.IdMetodoPago = (int)datos.lector["idMetodoPago"];
                    aux.MetodoPago.NombreMetodoPago = (string)datos.lector["nombreMetodoPago"];

                    listaMovimientos.Add(aux);
                }

                return listaMovimientos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarMovimientoCaja(MovimientosCaja nuevoMovimiento)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedAgregarMovimiento");
                Datos.setParametros("@fecha", nuevoMovimiento.Fecha);
                Datos.setParametros("@descripcion", nuevoMovimiento.Descripcion);
                Datos.setParametros("@monto", nuevoMovimiento.Monto);
                Datos.setParametros("@metodoPagoId", nuevoMovimiento.MetodoPago.IdMetodoPago);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }

        }
        public decimal RealizarCierreCaja(DateTime fecha, bool cierreSemanal)
        {
            AccesoDatos Datos = new AccesoDatos();
            decimal montoFinal = 0;

            try
            {
                Datos.setearStoredProcedure("storedCierreCaja");
                Datos.setParametros("@fecha", fecha);
                Datos.setParametros("@esCierreSemanal", cierreSemanal);
                Datos.EjecutarLectura();

                if (Datos.lector.Read())
                {
                    montoFinal = (decimal)Datos.lector["TotalMonto"];
                }

                return montoFinal;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método RealizarCierreCaja: " + ex.Message);
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }


    }

}
