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
                    aux.Dni = (int)datos.lector["dni"];
                    aux.Nombre = (string)datos.lector["nombre"];
                    aux.Apellido = (string)datos.lector["apellido"];
                    aux.fechaNacimiento = (DateTime?)(datos.lector["fechaNacimiento"] is DBNull ? (object)null : (DateTime)datos.lector["fechaNacimiento"]);
                    if (aux.fechaNacimiento != null)
                    {
                        DateTime hoy = DateTime.Today;
                        int edad = hoy.Year - aux.fechaNacimiento.Value.Year;

                        if (aux.fechaNacimiento.Value.Date > hoy.AddYears(-edad))
                        {
                            edad--;
                        }
                        aux.Edad = edad;
                    }
                    else
                    {
                        aux.Edad = null;
                    }

                    aux.Telefono = datos.lector["telefono"] is DBNull ? "Sin numero" : (string)datos.lector["telefono"];
                    aux.fechaInicio = (DateTime)datos.lector["fechaInicio"];
                    aux.Estado = datos.lector["estado"] is DBNull ? false : (bool)datos.lector["estado"];
                    aux.urlImagen = datos.lector["UrlImagen"] is DBNull ? "C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg" : (string)datos.lector["UrlImagen"];

                    aux.Tipo = new Membresias();
                    aux.Tipo.Id = (int)datos.lector["id"];
                    aux.Tipo.Tipo = (string)datos.lector["tipo"];

                    aux.Precio = (decimal)datos.lector["precio"];
                    aux.Duracion = (int)datos.lector["duracion"];

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
                Datos.setParametros("@dni", Nuevo.Dni);
                Datos.setParametros("@nombre", Nuevo.Nombre);
                Datos.setParametros("@apellido", Nuevo.Apellido);
                Datos.setParametros("@fechaNacimiento", Nuevo.fechaNacimiento);
                Datos.setParametros("@telefono", Nuevo.Telefono);
                Datos.setParametros("@urlImagen", Nuevo.urlImagen);
                Datos.setParametros("@fechaInicio", Nuevo.fechaInicio);
                Datos.setParametros("@idTipoMembresia", Nuevo.Tipo.Id);
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
        public void ModificarClienteConSP(Cliente selecionado, int dniAModificar)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearStoredProcedure("storedModificarCliente");
                Datos.setParametros("@dni", selecionado.Dni);
                Datos.setParametros("@nombre", selecionado.Nombre);
                Datos.setParametros("@apellido", selecionado.Apellido);
                Datos.setParametros("@fechaNacimiento", selecionado.fechaNacimiento);
                Datos.setParametros("@telefono", selecionado.Telefono);
                Datos.setParametros("@urlImagen", selecionado.urlImagen);
                Datos.setParametros("@fechaInicio", selecionado.fechaInicio);
                Datos.setParametros("@estado", selecionado.Estado);
                Datos.setParametros("@idTipoMembresia", selecionado.Tipo.Id);
                Datos.setParametros("@dniAModificar", dniAModificar);
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
