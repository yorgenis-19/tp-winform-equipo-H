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
    public partial class frmListadoArt : Form
    {
        private List<Articulo> listaArticulos;
        public frmListadoArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoArt_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negArt = new ArticuloNegocio();
            listaArticulos = negArt.listar();
            dgbArticulos.DataSource = listaArticulos;
            //dgbArticulos.Columns["ImagenUrl"].Visible = false;
        }



        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
          Articulo seleccionado = (Articulo) dgbArticulos.CurrentRow.DataBoundItem;
          cargarImagen(seleccionado.imagen.url);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);


            }
            catch (Exception)
            {
                pbArticulos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgNZcEIRZucZlqbOJpbEPlAcrj7OR7rgNKmj5m4Az8lg&s");
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaBusqueda;

            string busqueda = txtBuscar.Text;

            if(busqueda!= "")
            {

            listaBusqueda = listaArticulos.FindAll(art => art.id == int.Parse(busqueda));
            }
            else
            {
                listaBusqueda = listaArticulos;
            }


            dgbArticulos.DataSource = null;
            dgbArticulos.DataSource = listaBusqueda;
            dgbArticulos.Columns["Codigo"].Visible = false;
            
        }
    }
}
