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
            
            string categoria = cboCategoria.SelectedItem.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategoria.Items.Add("Articulos de limpieza");
            cboCategoria.Items.Add("Articulos escolares");
            cboCategoria.Items.Add("Articulos de cocina");
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
