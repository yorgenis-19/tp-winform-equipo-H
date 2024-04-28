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
    public partial class agregarArt : Form
    {
        private Articulo articulo = null; 

        public agregarArt()
        {
            InitializeComponent();
        }
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

       /* private bool validateFields()
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Codigo sin llenar");
                return false;
            }
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Nombre sin llenar");
                return false;
            }
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Descripcion sin llenar");
                return false;
            }
            if (!ValidarMarca())
            {
                return false;
            }
          /*  if (!ValidarCategoria())
            {
                return false;
            }*/
          /*  if (yaExiste())
            {
                MessageBox.Show("Ya existe un Articulo con ese codigo");
                return false;
            }
            return true;
        }*/

        private bool ValidarMarca()
        {
            MarcaDB marcaDB = new MarcaDB();
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = marcaDB.listar();

            foreach (var marca in listaMarca)
            {
                if (marca.Descripcion == cmbMarca.Text)
                {
                    return true;
                }
            }
            MessageBox.Show("Marca no valida");
            return false;
        }

        private bool ValidarCategoria()
        {
            CategoriaDB categoriaDB = new CategoriaDB();
            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria = categoriaDB.listar();
            foreach (var categoria in listaCategoria)
            {
                if (categoria.Descripcion == cmbCategoria.Text)
                {
                    return true;
                }
            }
            MessageBox.Show("Categoria no valida");
            return false;
        }

        public bool yaExiste()
        {
            ArticuloDB articuloDB = new ArticuloDB();
            List<Articulo> articulos = new List<Articulo>();
            articulos = articuloDB.listar();
            foreach (var articulo in articulos)
            {
                if (txtCodigo.Text == articulo.codigo)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           /* if (!validateFields())
            {
                return;
            }*/
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            ArticuloDB articuloDB = new ArticuloDB();
            Articulo articulo = new Articulo();
            articulo.codigo = txtCodigo.Text;
            articulo.nombre = txtNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.Marca = new Marca();
            articulo.Marca.Descripcion = cmbMarca.Text;
            articulo.Marca.Id = marcaDB.obtener(articulo.Marca.Descripcion);
            articulo.Categoria = new Categoria();
            articulo.Categoria.Descripcion = cmbCategoria.Text;
            articulo.Categoria.Id = categoriaDB.obtener(articulo.Categoria.Descripcion);
            articulo.precio = nupdPrecio.Value;

            articuloDB.agregar(articulo);

            MessageBox.Show("Articulo agregado exitosamente");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbMarca.Text = "";
            cmbCategoria.Text = "";
            nupdPrecio.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void agregarArt_Load(object sender, EventArgs e)
        {
            frmListadoArt frmListadoArt = new frmListadoArt(); // Lo voy a utilizar para cargar Imagen

            if(articulo != null)
            {
                txtNombre.Text = articulo.nombre;
                txtDescripcion.Text = articulo.descripcion;
                cmbMarca.Text = articulo.Marca.ToString();
                cmbCategoria.Text = articulo.Categoria.ToString();   
                txtCodigo.Text = articulo.codigo;
                           
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

        private void btnAgrMC_Click(object sender, EventArgs e)
        {
            agregarMarca_categoria aux = new agregarMarca_categoria();
            aux.ShowDialog();   
        }
    }
}
