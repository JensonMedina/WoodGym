using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class MetodosPagoDatos
    {
        public List<MetodosPago> listarMetodosPagoConSp()
        {
            List<MetodosPago> listaMetodosPago = new List<MetodosPago>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearStoredProcedure("storedListarMetodosPago");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    MetodosPago aux = new MetodosPago();
                    aux.IdMetodoPago = (int)datos.lector["idMetodoPago"];
                    aux.NombreMetodoPago = (string)datos.lector["nombreMetodoPago"];

                    listaMetodosPago.Add(aux);
                }
                return listaMetodosPago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
