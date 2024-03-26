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
        public void ModificarMovimientoCaja(MovimientosCaja seleccionado)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedModificarMovimiento");
                Datos.setParametros("@fecha", seleccionado.Fecha);
                Datos.setParametros("@descripcion", seleccionado.Descripcion);
                Datos.setParametros("@monto", seleccionado.Monto);
                Datos.setParametros("@metodoPagoId", seleccionado.MetodoPago.IdMetodoPago);
                Datos.setParametros("@transaccionId", seleccionado.TransaccionId);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al modificar el movimiento de caja. Por favor, inténtelo de nuevo más tarde.", ex);
            }
            finally
            {
                Datos.CerrarConexion();
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
        public decimal[] RealizarCierreCaja(DateTime fecha, bool cierreSemanal)
        {
            AccesoDatos Datos = new AccesoDatos();
            decimal[] montos = new decimal[8];
            for(int i = 0; i < 8; i++)
            {
                montos[i] = 0;
            }

            try
            {
                Datos.setearStoredProcedure("storedCierreCaja");
                Datos.setParametros("@fecha", fecha);
                Datos.setParametros("@esCierreSemanal", cierreSemanal);
                Datos.EjecutarLectura();

                while(Datos.lector.Read())
                {
                    montos[0] = (decimal)Datos.lector["IngresosEfectivo"];
                    montos[1] = (decimal)Datos.lector["GastosEfectivo"];
                    montos[2] = (decimal)Datos.lector["IngresosTransferencias"];
                    montos[3] = (decimal)Datos.lector["GastosTransferencias"];
                    montos[4] = (decimal)Datos.lector["IngresosGenerales"];
                    montos[5] = (decimal)Datos.lector["GastosGenerales"];
                    montos[6] = (decimal)Datos.lector["TotalEfectivo"];
                    montos[7] = (decimal)Datos.lector["TotalTransferencia"];
                }

                return montos;
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

        public bool ExistenMovimientosParaFecha(DateTime fecha, bool cierreSemanal)
        {
            // Consulta SQL para verificar si existen movimientos para la fecha y tipo de cierre
            AccesoDatos Datos = new AccesoDatos();
            {
                Datos.setearStoredProcedure("ExistenMovimientosParaFecha");
                Datos.setParametros("@fecha", fecha);
                Datos.setParametros("@esCierreSemanal", cierreSemanal);
                int cantidadRegistros = (int)Datos.EjecutarAccionScalar();

                    // Si cantidadRegistros es mayor que cero, existen movimientos para la fecha
                    return cantidadRegistros > 0;
            }
        }

        public List<MovimientosCaja> Filtrar(DateTime fecha, int idMetodoPago)
        {
            AccesoDatos Datos = new AccesoDatos();
            List<MovimientosCaja> Lista = new List<MovimientosCaja>();
            try
            {
                Datos.setearStoredProcedure("storedListarMovimientosFiltro");
                Datos.setParametros("@fecha", fecha);
                Datos.setParametros("@idMetodoPago", idMetodoPago);

                Datos.EjecutarLectura();
                while (Datos.lector.Read())
                {
                    MovimientosCaja aux = new MovimientosCaja();
                    aux.TransaccionId = (int)Datos.lector["transaccionId"];
                    aux.Fecha = (DateTime)Datos.lector["fecha"];
                    aux.Descripcion = (string)Datos.lector["descripcion"];
                    aux.Monto = (decimal)Datos.lector["monto"];
                    aux.MetodoPago = new MetodosPago();
                    aux.MetodoPago.IdMetodoPago = (int)Datos.lector["idMetodoPago"];
                    aux.MetodoPago.NombreMetodoPago = (string)Datos.lector["nombreMetodoPago"];
                    Lista.Add(aux);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
