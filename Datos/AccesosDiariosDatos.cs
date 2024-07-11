using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AccesosDiariosDatos
    {
        public void AgregarIngreso(int dni)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                DateTime fechaAcceso = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                Datos.setearStoredProcedure("storedIngreso");
                Datos.setParametros("@dni", dni);
                Datos.setParametros("@fecha", fechaAcceso);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método Ingresos: " + ex.Message);
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
    }
}
