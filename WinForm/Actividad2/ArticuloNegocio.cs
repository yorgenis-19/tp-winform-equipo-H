using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Actividad2
{
    internal class ArticuloNegocio
    {
        public  List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            MarcaDB marcadb = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS DescripcionMarca, M.Id AS IdMarca,C.Id as IdCategoria, C.Descripcion AS DescripcionCategoria, I.ImagenUrl\r\nFROM ARTICULOS A\r\nLEFT JOIN MARCAS M ON A.IdMarca = M.Id\r\nLEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id\r\nLEFT JOIN IMAGENES I ON A.Id = I.IdArticulo;";                     
                comando.Connection = conexion;  

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)lector["Id"];
                    aux.codigo = (string)lector["Codigo"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.precio = (decimal)lector["Precio"];
                    aux.imagen = new Imagen();
                    aux.imagen.url = (string)lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    int idMarca = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = marcadb.obtener(idMarca);
                    int idCategoria = (int)lector["IdCategoria"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = categoriaDB.obtener(idCategoria);

                    lista.Add(aux);
                }

                conexion.Close();   
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

   

     

       
        

        
       
    }

}
