using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class agregarMarca_categoria : Form
    {
        public agregarMarca_categoria()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaDB marcaDB = new MarcaDB();

            CategoriaDB categoriaDB = new CategoriaDB();
            ArticuloDB articuloDB = new ArticuloDB();
            Marca aux = new Marca();


           
            aux.Descripcion = txtMarc.Text;
            aux.Id = marcaDB.obtener(aux.Descripcion);
           
           

            articuloDB.agregarMarca(aux);

          
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            MarcaDB marcaDB = new MarcaDB();

            CategoriaDB categoriaDB = new CategoriaDB();
            ArticuloDB articuloDB = new ArticuloDB();
            Categoria aux = new Categoria();

            aux.Descripcion = txtCat.Text;
            aux.Id = marcaDB.obtener(aux.Descripcion);
            articuloDB.agregarCategoria(aux);
        }

        private void btnEliminarCarc_Click(object sender, EventArgs e)
        {

            try
            {
                string Descripcion = txtMarc.Text;  
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from MARCAS where Descripcion = @Descripcion");
                datos.setearParametro("@Descripcion", Descripcion);
                datos.ejecutarAccion();
                



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {

            try
            {
                string Descripcion = txtCat.Text;
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from CATEGORIAS where Descripcion = @Descripcion");
                datos.setearParametro("@Descripcion", Descripcion);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModMarc_Click(object sender, EventArgs e)
        {
            EditarMrca_Articulo modificar = new EditarMrca_Articulo();
            modificar.ShowDialog();

        }

        private void btnModCat_Click(object sender, EventArgs e)
        {
            EditarMrca_Articulo modificar = new EditarMrca_Articulo();
            modificar.ShowDialog();
        }
    }
}
