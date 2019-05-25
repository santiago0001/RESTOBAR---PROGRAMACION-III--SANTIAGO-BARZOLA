using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp4.Bebidas
{
    public partial class ABMmarcas : Form
    {
        string Clave;
        TipoPlatoNegocio negocioTipo = new TipoPlatoNegocio();

        TipoPlato tipoaselec = new TipoPlato();
        private TipoPlato TipoLocal = new TipoPlato();
        private List<TipoPlato> listarTipoLocal;

        MarcaNegocio negocio = new MarcaNegocio();
        Marca marcaselec = new Marca();
        private Marca MarcaLocal = new Marca();
        private List<Marca> listarMarcaLocal;

        public ABMmarcas(string clave)
        {
            InitializeComponent();
            Clave = clave;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtmar.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de marca");
            }
            if (Clave == "marca") { 
           
           
                MarcaLocal.Nombre = txtmar.Text;
                MarcaLocal.Estado = true;
                negocio.agregarMarca(MarcaLocal);
                cargarGrilla();
            
            }

            if (Clave == "tipo")
            {
                TipoLocal.nombre = txtmar.Text;
                TipoLocal.estado = true;
                negocioTipo.agregarMarca(TipoLocal);
                cargarGrilla();

            }


            }

            private void ABMmarcas_Load(object sender, EventArgs e)
        {
            if (Clave == "tipo")
            {
                labTipo.Text = "Tipo de Plato";
            }
            cargarGrilla();
            this.dgvMarcas.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        void cargarGrilla()
        {
            // crea negocio para listar insumos

            try
            { 
                
                if (Clave == "marca") {

                listarMarcaLocal = negocio.listarMarcas();
                dgvMarcas.DataSource = listarMarcaLocal;
                //Ocultar columnas
                dgvMarcas.Columns[0].Visible = false;
                dgvMarcas.Columns["estado"].Visible = false;
                }

                if (Clave == "tipo")
                {
                    listarTipoLocal = negocioTipo.listarTipoPlato();
                    dgvMarcas.DataSource = listarTipoLocal;
                    //Ocultar columnas
                   // dgvMarcas.Columns[0].Visible = false;
                   // dgvMarcas.Columns["estado"].Visible = false;
                }



                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            marcaselec = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            txtmodi.Text = marcaselec.Nombre;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            marcaselec.Nombre = txtmodi.Text;
            negocio.modificarMarca(marcaselec);
            cargarGrilla();


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Papelera pap = new Papelera("marca");
            pap.ShowDialog();
            cargarGrilla();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            negocio.DeleteMarca((Marca)dgvMarcas.CurrentRow.DataBoundItem);
            cargarGrilla();
        }
    }
}
