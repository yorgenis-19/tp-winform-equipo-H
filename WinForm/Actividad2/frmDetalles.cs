using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Actividad2
{
    public partial class frmDetalles : Form
    {
        public frmDetalles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // consulto db (ID == idingresado)



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
