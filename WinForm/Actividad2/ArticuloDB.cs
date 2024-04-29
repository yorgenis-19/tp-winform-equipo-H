using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    internal class ArticuloDB
    {
        public void agregarCategoria(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values ('" + nuevo.Descripcion + "')");
                datos.setearParametro("@idMarca", nuevo.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void agregarMarca(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
            datos.setearConsulta("insert into MARCAS (Descripcion) values ('" +  nuevo.Descripcion + "')");
            datos.setearParametro("@idCategoria", nuevo.Id);
            datos.ejecutarAccion();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            finally { datos.cerrarConexion(); }
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) values ('" + nuevo.codigo + "','" + nuevo.nombre + "','" + nuevo.descripcion + "','" + nuevo.precio + "', @idMarca, @idCategoria)");
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                datos.setearConsulta("select * from articulos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.id = (int)datos.Lector["Id"];
                    articulo.codigo = (string)datos.Lector["Codigo"];
                    articulo.nombre = (string)datos.Lector["Nombre"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    int idMarca = (int)datos.Lector["IdMarca"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = marcaDB.obtener(idMarca);
                    int idCategoria = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = categoriaDB.obtener(idCategoria);
                    articulo.precio = (decimal)datos.Lector["Precio"];
                    lista.Add(articulo);

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

        public void modificarCategoria(Categoria reg)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("update CATEGORIAS set  Descripcion = @descripcion WHERE id = '" + reg.Id + "' ");
                accesoDatos.setearParametro("@descripcion", reg.Descripcion);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }


        public void modificarMarca(Marca reg)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("update MARCAS set  Descripcion = @descripcion WHERE id = '" + reg.Id + "' ");
                accesoDatos.setearParametro("@descripcion", reg.Descripcion);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }


        public void modificar(Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @IdCategoria, Precio = @precio WHERE id = '" + articulo.id + "'");
                accesoDatos.setearParametro("@codigo", articulo.codigo);
                accesoDatos.setearParametro("@nombre", articulo.nombre);
                accesoDatos.setearParametro("@descripcion", articulo.descripcion);
                accesoDatos.setearParametro("@IdMarca", articulo.Marca.Id);
                accesoDatos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                accesoDatos.setearParametro("@precio", articulo.precio);

                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }

        public Articulo obtener(string codigo)
        {
            ///Metodo para optener un articulo mediante un Codigo de producto
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM ARTICULOS WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();
                Articulo articulo;
                if (reader.Read())
                {
                    articulo = new Articulo();
                    articulo.id = (int)reader["Id"];
                    articulo.codigo = (string)reader["Codigo"];
                    articulo.nombre = (string)reader["Nombre"];
                    articulo.descripcion = (string)reader["Descripcion"];
                    int idMarca = (int)reader["IdMarca"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = marcaDB.obtener(idMarca);
                    int idCategoria = (int)reader["IdCategoria"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = categoriaDB.obtener(idCategoria);
                    articulo.precio = (decimal)reader["Precio"];

                    return articulo;
                }
                else
                {
                    //MessageBox.Show("Articulo no encontrado");
                    return articulo = null;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                connection.Close();

            }
        }
    }
}

