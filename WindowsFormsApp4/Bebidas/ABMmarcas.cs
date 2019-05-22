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
        MarcaNegocio negocio = new MarcaNegocio();

        Marca marcaselec = new Marca();
        private Marca MarcaLocal = new Marca();

        private List<Marca> listarMarcaLocal;

        public ABMmarcas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtmar.Text=="")
            {
                MessageBox.Show("Debe ingresar un nombre de marca");
            }
            else
            {
                MarcaNegocio negocio = new MarcaNegocio();
                MarcaLocal.Nombre = txtmar.Text;
                MarcaLocal.Estado = true;
                negocio.agregarMarca(MarcaLocal);
                cargarGrilla();
            }
        }

        private void ABMmarcas_Load(object sender, EventArgs e)
        {
            
            cargarGrilla();
            this.dgvMarcas.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        void cargarGrilla()
        {
            // crea negocio para listar insumos

            try
            { //lista insumos
                listarMarcaLocal = negocio.listarMarcas();
                dgvMarcas.DataSource = listarMarcaLocal;
                //Ocultar columnas
                dgvMarcas.Columns[0].Visible = false;
                dgvMarcas.Columns["estado"].Visible = false;


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
