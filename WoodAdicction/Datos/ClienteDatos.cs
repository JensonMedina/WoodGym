using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Datos
{
    public class ClienteDatos
    {
        public List<Cliente> listarClientesConSP()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearStoredProcedure("storedListar");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.dni = (int)datos.lector["dni"];
                    aux.nombre = (string)datos.lector["nombre"];
                    aux.apellido = (string)datos.lector["apellido"];
                    aux.fechaNacimiento = datos.lector["fechaNacimiento"] is DBNull ? DateTime.Now : (DateTime)datos.lector["fechaNacimiento"];
                    
                    aux.telefono = datos.lector["telefono"] is DBNull ? "Sin numero" : (string)datos.lector["telefono"];
                    aux.fechaInicio = (DateTime)datos.lector["fechaInicio"];
                    aux.estado = datos.lector["estado"] is DBNull ? false : (bool)datos.lector["estado"];
                    aux.urlImagen = datos.lector["UrlImagen"] is DBNull ? "C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg" : (string)datos.lector["UrlImagen"];

                    aux.tipo = new Membresias();
                    aux.tipo.id = (int)datos.lector["id"];
                    aux.tipo.tipo = (string)datos.lector["tipo"];

                    aux.precio = (decimal)datos.lector["precio"];
                    aux.duracion = (int)datos.lector["duracion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarClienteConSP(Cliente Nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedAltaCliente");
                Datos.setParametros("@dni", Nuevo.dni);
                Datos.setParametros("@nombre", Nuevo.nombre);
                Datos.setParametros("@apellido", Nuevo.apellido);
                Datos.setParametros("@fechaNacimiento", Nuevo.fechaNacimiento);
                Datos.setParametros("@telefono", Nuevo.telefono);
                Datos.setParametros("@urlImagen", Nuevo.urlImagen);
                Datos.setParametros("@fechaInicio", Nuevo.fechaInicio);
                Datos.setParametros("@idTipoMembresia", Nuevo.tipo.id);
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
    }
}
