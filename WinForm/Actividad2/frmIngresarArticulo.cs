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
    public partial class frmIngresarArticulo : Form
    {
        public frmIngresarArticulo()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string categoria = cmbCategoria.SelectedItem.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Articulos de limpieza");
            cmbCategoria.Items.Add("Articulos escolares");
            cmbCategoria.Items.Add("Articulos de cocina");
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateFields()
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
            if (!ValidarCategoria())
            {
                return false;
            }
            if (yaExiste())
            {
                MessageBox.Show("Ya existe un Articulo con ese codigo");
                return false;
            }
            return true;
        }

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
            if (!validateFields())
            {
                return;
            }
            MarcaDB marcaDB = new MarcaDB();
            //CategoriaDB categoriaDB = new CategoriaDB();

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
            articulo.Categoria.Id = categoriaDB.obtener(articulo.categoria.Descripcion);
            articulo.precio = numPrecio.Value;

            articuloDB.agregar(articulo);

            MessageBox.Show("Articulo agregado exitosamente");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbMarca.Text = "";
            cmbCategoria.Text = "";
            numPrecio.Value = 0;
           
        }
    }
}
