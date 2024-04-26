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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }



        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();
            ArticuloDB articuloDB = new ArticuloDB();


            try
            {
                articulo.nombre = txtNombre.Text;
                articulo.precio = nupdPrecio.Value;
                articulo.codigo = txtCodigo.Text;
                articulo.descripcion = txtDescripcion.Text;
                articulo.Marca = new Marca();
                articulo.Marca.Descripcion = txtbMarca.Text;
                articulo.Marca.Id = marcaDB.obtener(articulo.Marca.Descripcion);
                articulo.Categoria = new Categoria();
                articulo.Categoria.Descripcion = nCategoria.Text;
                articulo.Categoria.Id = categoriaDB.obtener(articulo.Categoria.Descripcion);

                articuloDB.modificar(articulo);
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
