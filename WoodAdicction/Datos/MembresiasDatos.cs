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
                    aux.Nombre = (string)datos.lector["nombre"];
                    aux.Descripcion = (string)datos.lector["descripcion"];
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


        public void AgregarMembresia(Membresias nuevaMembresia)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedAgregarMembresia");
                Datos.setParametros("@nombre", nuevaMembresia.Nombre);
                Datos.setParametros("@precio", nuevaMembresia.Precio);
                Datos.setParametros("@descripcion", nuevaMembresia.Descripcion);
                Datos.setParametros("@duracion", nuevaMembresia.Duracion);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar la membresía. Por favor, inténtelo de nuevo más tarde.", ex);
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public decimal ObtenerPrecioMembresia(int id)
        {
            AccesoDatos Datos = new AccesoDatos();
            decimal precio = 0;
            try
            {
                Datos.setearStoredProcedure("ObtenerPrecioMembresia");
                Datos.setParametros("@id", id);
                Datos.EjecutarLectura();
                while (Datos.lector.Read())
                {
                    precio = (decimal)Datos.lector["precio"];
                }
                return precio;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
        public void ModificarMembresia(Membresias selecionada)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedModificarMembresia");
                Datos.setParametros("@nombre", selecionada.Nombre);
                Datos.setParametros("@precio", selecionada.Precio);
                Datos.setParametros("@descripcion", selecionada.Descripcion);
                Datos.setParametros("@duracion", selecionada.Duracion);
                Datos.setParametros("@id", selecionada.Id);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al modificar la membresía. Por favor, inténtelo de nuevo más tarde.", ex);
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
        public void EliminarMembresia (int id)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedEliminarMembresia");
                Datos.setParametros("@id", id);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar la membresía. Por favor, inténtelo de nuevo más tarde.", ex);
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
    }
}
