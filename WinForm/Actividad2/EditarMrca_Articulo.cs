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
    public partial class EditarMrca_Articulo : Form
    {
        public EditarMrca_Articulo()
        {
            InitializeComponent();
        }

        private void btnModMarc_Click(object sender, EventArgs e)
        {

                Marca reg = new Marca();
           
            MarcaDB marcaDB = new MarcaDB();
       
            ArticuloDB articuloDB = new ArticuloDB();


            try
            {

                reg.Descripcion = txtNuevoNombreMarc.Text;
                reg.Id = int.Parse(txtMarcEdit.Text);
             

                articuloDB.modificarMarca(reg);
                MessageBox.Show("Editado correctamente");

                Close();



            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnModCat_Click(object sender, EventArgs e)
        {
            Categoria reg = new Categoria();

      
            CategoriaDB categoriaDB = new CategoriaDB();
            ArticuloDB articuloDB = new ArticuloDB();


            try
            {

                reg.Descripcion = txtNuevoNombreCat.Text;
                reg.Id = int.Parse(txtCatEdit.Text);


                articuloDB.modificarCategoria(reg);
                MessageBox.Show("Editado correctamente");

                Close();



            }
            catch (Exception)
            {

                throw;
            }

        }

      
    }
}
