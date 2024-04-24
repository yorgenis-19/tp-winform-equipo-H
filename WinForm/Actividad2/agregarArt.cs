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
        public agregarArt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                nuevo.nombre = txtNombre.Text;
                nuevo.descripcion = txtDescripcion.Text;
                nuevo.codigo = txtCodigo.Text;
                nuevo.precio = int.Parse(nupdPrecio.Text);
               

                articuloDB.agregar(nuevo);
                MessageBox.Show("Agregado exitosamente");
                Close();
                

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
