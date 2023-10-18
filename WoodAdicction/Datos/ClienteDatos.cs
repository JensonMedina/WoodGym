﻿using System;
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
        public List<Cliente> listarConSP()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select C.dni, C.Nombre, C.fechaInicio, C.UrlImagen, C.estado, M.tipo, M.id, M.duracion From Clientes C, Membresias M Where M.id = C.idTipoMembresia";

                datos.setQuery(consulta);
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.dni = (int)datos.lector["dni"];
                    aux.Nombre = (string)datos.lector["nombre"];
                    aux.fechaInicio = (DateTime)datos.lector["fechaInicio"];
                    aux.estado = datos.lector["estado"] is DBNull ? false : (bool)datos.lector["estado"];
                    aux.urlImagen = datos.lector["UrlImagen"] is DBNull ? "C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg" : (string)datos.lector["UrlImagen"];

                    //aux.estado = (bool)datos.lector["ESTADO"];

                    //if (!(datos.lector["UrlImagen"] is DBNull))
                    //    aux.urlImagen = (string)datos.lector["UrlImagen"];

                    aux.tipo = new Membresias();
                    aux.tipo.id = (int)datos.lector["id"];
                    aux.tipo.tipo = (string)datos.lector["tipo"];
                    aux.tipo.duracion = (int)datos.lector["duracion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
