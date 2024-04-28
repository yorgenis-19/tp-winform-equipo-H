using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public class ImagenDB
    {
        public void agregar(Imagen imagen)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into IMAGENES values ('" + imagen.idArticulo + "', '" + imagen.url + "')";
                cmd.Connection = connection;
                connection.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La imagen " + imagen.url + " no se pudo cargar...");
            }
            finally { connection.Close(); }
        }
    }
}
