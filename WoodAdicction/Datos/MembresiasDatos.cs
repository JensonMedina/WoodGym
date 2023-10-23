using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class MembresiasDatos
    {
        public List<Membresias> listarMembresiasConSp()
        {
            try
            {
                List<Membresias> listaMembresias = new List<Membresias>();
                AccesoDatos datos = new AccesoDatos();
                datos.setearStoredProcedure("storedListarMembresias");
                datos.EjecutarLectura();
                while (datos.lector.Read())
                {
                    Membresias aux = new Membresias();
                    aux.Id = (int)datos.lector["id"];
                    aux.Tipo = (string)datos.lector["tipo"];
                    aux.Precio = (decimal)datos.lector["precio"];
                    aux.Duracion = (int)datos.lector["duracion"];
                    listaMembresias.Add(aux);
                }
                return listaMembresias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
