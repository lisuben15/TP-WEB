using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using dominio;
namespace negocio

{
    public class ServicioArticulo 
    {
            public void AgregarArticulo(Articulo articulo)
            {
                AccesoDatos datos = new AccesoDatos();
           
                try
                {
                    datos.setearConsulta("insert into ARTICULOS values('"+articulo.Codigo+"', '"+articulo.Nombre+"', '"+ articulo.Descripcion+"',"+articulo.Marca.Id+" ,"+articulo.Categoria.Id+","+articulo.Precio+")");
                    datos.ejecutarAccion();
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }

             }

        public int seleccionoUltimoRegistro(Articulo articulo)
            {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select top(1) Id from ARTICULOS order by Id desc");
                datos.ejecutarLectura();
                datos.Lector.Read();
                return (int)datos.Lector["Id"];
            }


            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void GuardarImagenRelacionada(int idArticulo, string urlImagen)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {           
                datos.setearConsulta("insert into IMAGENES values(" + idArticulo + ", '" + urlImagen + "')");
                datos.ejecutarAccion();
            }


            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void ModificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where id = @Id");
                datos.setearParametros("@Codigo", articulo.Codigo);
                datos.setearParametros("@Nombre", articulo.Nombre);
                datos.setearParametros("@Descripcion", articulo.Descripcion);
                datos.setearParametros("@IdMarca", articulo.Marca.Id);
                datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametros("@Precio", articulo.Precio);
                datos.setearParametros("@Id", articulo.Id);

                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

        }
        public void EliminarArticulo(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS WHERE Id = @id");
                datos.setearParametros("@id", Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
                EliminarImagenes(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarImagenes(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("delete from IMAGENES WHERE IdArticulo = @id");
            datos.setearParametros("@id", Id);
            datos.ejecutarAccion();
        }

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT a.Id, Codigo, Nombre, a.Descripcion, m.Id as IdMarca, m.Descripcion AS Marca, c.Id as IdCategoria, c.Descripcion AS Categoria, Precio, i.ImagenUrl FROM ARTICULOS a INNER JOIN MARCAS m ON  a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];// mapaer
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];;

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = datos.Lector["ImagenUrl"] != DBNull.Value ? datos.Lector["ImagenUrl"].ToString() : null;

                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> FiltrarArticulos(string consulta)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];// mapaer
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = datos.Lector["ImagenUrl"] != DBNull.Value ? datos.Lector["ImagenUrl"].ToString() : null;

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<string> ListarImagenes(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            List<string> lista = new List<string>();
            try
            {
                datos.setearConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @id");
                datos.setearParametros("@id", Id);
                datos.ejecutarLectura();
                string aux;
                while (datos.Lector.Read())
                {
                    aux = (string)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool BUscarCodigoDuplicado(string codigo)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE Codigo = @Codigo");
                datos.comando.Parameters.AddWithValue("@Codigo", codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int count = datos.Lector.GetInt32(0);
                    return count > 0;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void AgregarImagenes(int Id, List<string> UrlsImagenes)
        {
            try
            {
                for (int i = 0; i < UrlsImagenes.Count; i++)
                {
                    GuardarImagenRelacionada(Id, UrlsImagenes[i]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
