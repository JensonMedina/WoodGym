using System;
using System.Collections.Generic;
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
    }
}
