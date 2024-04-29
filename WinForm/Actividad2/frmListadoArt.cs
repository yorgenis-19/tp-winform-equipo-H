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

        private void cargar()
        {
            ArticuloNegocio negArt = new ArticuloNegocio();
            listaArticulos = negArt.listar();
            dgbArticulos.DataSource = listaArticulos;
            //dgbArticulos.Columns["ImagenUrl"].Visible = false;
        }

            private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
            {
             if(dgbArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo) dgbArticulos.CurrentRow.DataBoundItem;
                if(seleccionado != null && seleccionado.imagen != null) 
                { 
                    cargarImagen(seleccionado.imagen.url);
                }

            }
            }

        public void cargarImagen(string imagen)
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

            string busqueda = txtVerDetalle.Text;

            if(busqueda!= "")
            {

            listaBusqueda = listaArticulos.FindAll(art =>  art.id == int.Parse(busqueda));
            }
            else
            {
                listaBusqueda = listaArticulos;
            }


            dgbArticulos.DataSource = null;
            dgbArticulos.DataSource = listaBusqueda;
            //dgbArticulos.Columns["Codigo"].Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que queres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes) 
                { 
                    seleccionado = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;
                    eliminarArticulos(seleccionado.id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void eliminarArticulos(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
                cargar();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            agregarArt agregarArt = new agregarArt();
            agregarArt.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtroMarca = txtFiltroMarc.Text;
            string filtroCategoria = txtFiltroCat.Text;
       

            if (filtroMarca != "" && filtroCategoria != "" && txtPrecio.Text != "")
            {

                listaFiltrada = listaArticulos.FindAll(x => x.Marca.ToString() == filtroMarca && x.Categoria.ToString() == filtroCategoria && x.precio <= decimal.Parse(txtPrecio.Text));
            }

            else if (filtroMarca != "" && filtroCategoria != "")
              {
                    listaFiltrada = listaArticulos.FindAll(x => x.Marca.ToString() == filtroMarca && x.Categoria.ToString() == filtroCategoria);
              }
              else if (filtroMarca != "" && txtPrecio.Text != "")
               {
                        listaFiltrada = listaArticulos.FindAll(x => x.Marca.ToString() == filtroMarca && x.precio <= decimal.Parse(txtPrecio.Text));
               }
                else if(filtroCategoria != "" && txtPrecio.Text != "")
                 {
                       listaFiltrada = listaArticulos.FindAll(x => x.Categoria.ToString() == filtroCategoria && x.precio <= decimal.Parse(txtPrecio.Text));
                 }
                 else if(filtroMarca != "")
                  {
                     listaFiltrada = listaArticulos.FindAll(x => x.Marca.ToString() == filtroMarca);
                  }
                  else if(filtroCategoria != "")
                   {
                     listaFiltrada = listaArticulos.FindAll(x => x.Categoria.ToString() == filtroCategoria);
                   }
                   else if (txtPrecio.Text != "")
                    {
                    listaFiltrada = listaArticulos.FindAll(x => x.precio <= decimal.Parse(txtPrecio.Text));
                    }
            
                  else
                   {
                   listaFiltrada = listaArticulos;
                   }


            dgbArticulos.DataSource = null;
            dgbArticulos.DataSource = listaFiltrada;
            dgbArticulos.Columns["Codigo"].Visible = false;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;
            Modificar modificar = new Modificar();
            modificar.ShowDialog();
            cargar();

        }

        private void btnMarcaCategoria_Click(object sender, EventArgs e)
        {
            agregarMarca_categoria reg = new agregarMarca_categoria();
            reg.ShowDialog();   
        }
    }
}
