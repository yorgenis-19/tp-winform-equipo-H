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

        Articulo articulo = null;

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
                articulo.Marca.Descripcion = cmbMarca.Text;
                articulo.Marca.Id = marcaDB.obtener(articulo.Marca.Descripcion);
                articulo.Categoria = new Categoria();
                articulo.Categoria.Descripcion = cmbCategoria.Text;
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

        private void Modificar_Load(object sender, EventArgs e)
        {
            

            cmbMarca.Items.Clear();
            MarcaDB marcaDB = new MarcaDB();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaDB.listar();

            foreach (var marca in listaMarca)
            {
                cmbMarca.Items.Add(marca.Descripcion.ToString());

            }



            cmbCategoria.Items.Clear();
            CategoriaDB categoriaDB = new CategoriaDB();
            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = categoriaDB.listar();

            foreach (var Categoria in listaCategoria)
            {
                cmbCategoria.Items.Add(Categoria.Descripcion.ToString());
            }
            
            MarcaDB mar = new MarcaDB();
            CategoriaDB cat = new CategoriaDB();

            try
                {
                    cmbMarca.DataSource = mar.listar();
                    cmbCategoria.DataSource = cat.listar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }



            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

