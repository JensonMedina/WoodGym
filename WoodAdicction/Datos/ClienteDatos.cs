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
                datos.setearStoredProcedure("storedListarClientes");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Dni = (int)datos.lector["dni"];
                    aux.NroSocio = (int)datos.lector["nroSocio"];
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
                    aux.Activo = datos.lector["activo"] is DBNull ? false : (bool)datos.lector["activo"];
                    aux.urlImagen = datos.lector["imagenUrl"] is DBNull ? "C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg" : (string)datos.lector["imagenUrl"];

                    aux.TipoMembresia = new Membresias();
                    aux.TipoMembresia.Id = (int)datos.lector["id"];
                    aux.TipoMembresia.Nombre = (string)datos.lector["Nombre"];

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
                Datos.setParametros("@imagenUrl", Nuevo.urlImagen);
                Datos.setParametros("@fechaInicio", Nuevo.fechaInicio);
                Datos.setParametros("@activo", Nuevo.Activo);
                Datos.setParametros("@idTipoMembresia", Nuevo.TipoMembresia.Id);
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
        public void ModificarClienteConSP(Cliente selecionado, int dniAmodificar)
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
                Datos.setParametros("@imagenUrl", selecionado.urlImagen);
                Datos.setParametros("@fechaInicio", selecionado.fechaInicio);
                Datos.setParametros("@activo", selecionado.Activo);
                Datos.setParametros("@idTipoMembresia", selecionado.TipoMembresia.Id);
                Datos.setParametros("@socioAmodificar", dniAmodificar);
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


        public List<Cliente> Filtrar(int dni, string añoInicio, string mesInicio, string tipoMembresia, int Edad, string estado)
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Cliente> Lista = new List<Cliente>();
            try
            {
                string Consulta = "select C.dni, C.nroSocio, C.nombre, C.apellido, C.fechaNacimiento, C.telefono, C.imagenUrl, C.fechaInicio, C.activo, M.id, M.nombre from Clientes C, Membresias M where C.idTipoMembresia = M.id ";
                if (dni != -1)
                {
                    Consulta += "And C.dni = " + dni;
                }
                if(añoInicio != null && mesInicio != null)
                {
                    string fechaInicio;
                    fechaInicio = añoInicio+ "-" + mesInicio + "-01";
                    string fechaFin;
                    fechaFin = añoInicio + "-" + mesInicio + "-30";
                    Consulta += " And C.fechaInicio >= '" + fechaInicio + "'" + " And C.fechaInicio <= '" + fechaFin + "'";
                }
                else
                {
                    if(añoInicio != null && mesInicio == null)
                    {
                        string fechaInicio;
                        fechaInicio = añoInicio + "-01-01";
                        string fechaFin;
                        fechaFin = añoInicio + "-12-31";
                        Consulta += " And C.fechaInicio >= '" + fechaInicio + "'" + " And C.fechaInicio <= '" + fechaFin + "'";
                    }
                    else
                    {
                        if(añoInicio == null && mesInicio != null)
                        {
                            string añoActual = DateTime.Now.Year.ToString();
                            string fechaInicio;
                            fechaInicio = añoActual + "-" + mesInicio + "-01";
                            string fechaFin;
                            fechaFin = añoActual + "-" + mesInicio + "-30";
                            Consulta += " And C.fechaInicio >= '" + fechaInicio + "'" + " And C.fechaInicio <= '" + fechaFin + "'";
                        }
                    }
                }
                if(tipoMembresia != null)
                {
                    Consulta += " And UPPER(M.nombre) = '" + tipoMembresia.ToUpper() + "'";
                }
                if(estado != null)
                {
                    if(estado.ToUpper() == "ACTIVO")
                    {
                        Consulta += " And C.activo = 1";
                    }
                    else
                    {
                        Consulta += "And c.activo = 0";
                    }
                }
                Datos.setearConsulta(Consulta);
                
                Datos.EjecutarLectura();
                while (Datos.lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Dni = (int)Datos.lector["dni"];
                    aux.NroSocio = (int)Datos.lector["nroSocio"];
                    aux.Nombre = (string)Datos.lector["nombre"];
                    aux.Apellido = (string)Datos.lector["apellido"];
                    aux.fechaNacimiento = (DateTime)Datos.lector["fechaNacimiento"];
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
                    aux.Telefono = Datos.lector["telefono"] is DBNull ? "Sin numero" : (string)Datos.lector["telefono"];
                    aux.fechaInicio = (DateTime)Datos.lector["fechaInicio"];
                    aux.Activo = Datos.lector["activo"] is DBNull ? false : (bool)Datos.lector["activo"];
                    aux.urlImagen = Datos.lector["imagenUrl"] is DBNull ? "C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg" : (string)Datos.lector["imagenUrl"];

                    aux.TipoMembresia = new Membresias();
                    aux.TipoMembresia.Id = (int)Datos.lector["id"];
                    aux.TipoMembresia.Nombre = (string)Datos.lector["nombre"];
                    if(Edad != -1)
                    {
                        if(aux.Edad == Edad)
                        {
                            Lista.Add(aux);
                        }
                    }
                    else
                    {
                        Lista.Add(aux);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método Filtrar: " + ex.Message);
            }
        }
    }
}
