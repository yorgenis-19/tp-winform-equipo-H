using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class MarcaDB
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from MARCAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)lector["Id"];
                    marca.Descripcion = (string)lector["Descripcion"];
                    lista.Add(marca);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int obtener(string desc)
        {
            int marcaID;
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[MARCAS] WHERE Descripcion = @desc";
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    marcaID = (int)reader["Id"];
                }
                else
                {
                    marcaID = 0;
                }

                return marcaID;
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

        public string obtener(int id)
        {
            string marcaName;
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[MARCAS] WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    marcaName = (string)reader["Descripcion"];
                }
                else
                {
                    marcaName = "N/A";
                }

                return marcaName;
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
