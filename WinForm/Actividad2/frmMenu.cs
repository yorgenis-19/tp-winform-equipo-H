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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIngresarArticulo ventana = new frmIngresarArticulo();
            ventana.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar();
            frmEliminar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDetalles frmDetalles = new frmDetalles();
            frmDetalles.ShowDialog();
        }

        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            ModificarArticulo modificar = new ModificarArticulo();
            modificar.ShowDialog();
        }
    }
}
