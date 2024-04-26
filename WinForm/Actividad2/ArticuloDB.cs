using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    internal class ArticuloDB
    {
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

        public void modificar(Articulo articulo)
        {
               AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @IdCategoria, Precio = @precio WHERE id = 1");
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

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
    }
}
