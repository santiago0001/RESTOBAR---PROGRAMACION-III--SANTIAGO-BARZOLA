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
using AccesoDatos;
using System.Data.SqlClient;
using WindowsFormsApp4.Bebidas;


namespace Negocio
{
    public partial class AltaPlato : Form
    {
        private List<TipoPlato> ListaTipoPlatosLocal;
        TipoPlatoNegocio negocio = new TipoPlatoNegocio();

        private List<VajillaXpla> listaVajillaLocal;
        VajillaXPlaNegocio negocioVaji = new VajillaXPlaNegocio();

        private List<Insumo> listaInsumo;
        VajillaXPlaNegocio negocioInsumo = new VajillaXPlaNegocio();
        Insumo va = new Insumo();

        private Plato PlatoLocal = null;

        public AltaPlato()
        {
            InitializeComponent();
           
        }
        public AltaPlato(Plato plato)
        {
            InitializeComponent();
            PlatoLocal = plato;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                PlatoNegocio negocio = new PlatoNegocio();

                // si es nuevo
                if (PlatoLocal == null)
                    PlatoLocal = new Plato();

            // si es existente
            PlatoLocal.Tipo = (TipoPlato)comboBoxPla.SelectedItem;
            PlatoLocal.Descripcion = txtDesc.Text;
                PlatoLocal.Nombre = txtNombrePla.Text;
                PlatoLocal.Precio = Convert.ToDecimal(txtPrecioPla.Text);
               // PlatoLocal.Tipo = comboBoxPla.Text;




                //si es existente 
            if (PlatoLocal.id != 0)
                {
                    negocio.modificarPlato(PlatoLocal);
                }
                // si es nuevo
                else
                {
                    negocio.agregarPlato(PlatoLocal);
                }

                Close();
            
        }
        private void LlenarComboVajilla()
        {

            listaInsumo = negocioInsumo.listarVajilla();
            comboVajilla.DataSource = null;
            comboVajilla.DataSource = listaInsumo;
            comboVajilla.DisplayMember = "Nombre";
            comboVajilla.ValueMember = "Id";
        }
        private void LlenarComboTipo()
        {

            ListaTipoPlatosLocal = negocio.listarTipoPlato();
            comboBoxPla.DataSource = null;
            comboBoxPla.DataSource = ListaTipoPlatosLocal;
            comboBoxPla.DisplayMember = "Nombre";
            comboBoxPla.ValueMember = "Id";
        }

        private void cargarGrilla ()
        {
            if (PlatoLocal != null)
            {
                listaVajillaLocal = negocioVaji.listarVajillaXpla(Convert.ToInt64(idLabel.Text));
                dgvVajilla.DataSource = listaVajillaLocal;
                dgvVajilla.Columns["plato"].Visible = false;
                dgvVajilla.Columns["idpla"].Visible = false;
                dgvVajilla.Columns["idvaj"].Visible = false;


            }


        }


        private void AltaPlato_Load(object sender, EventArgs e)
        {
            this.dgvVajilla.SelectionMode =
             DataGridViewSelectionMode.FullRowSelect;
            LlenarComboTipo();
            // carga en fromulario si existe plato local
            if (PlatoLocal != null)
            {
                txtNombrePla.Text = PlatoLocal.Nombre;
                idLabel.Text = PlatoLocal.id.ToString();
                txtPrecioPla.Text = PlatoLocal.Precio.ToString();
                txtDesc.Text = PlatoLocal.Descripcion;
                comboBoxPla.SelectedIndex = comboBoxPla.FindString(PlatoLocal.Tipo.nombre);

            }
            
            cargarGrilla();
            LlenarComboVajilla();
            // da de baja botones de plato por vajilla
            if (PlatoLocal==null)
            {
                button1.Enabled = false;
                comboVajilla.Enabled = false;
                dgvVajilla.Enabled = false;
                button2.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecioPla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePla_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxPla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BotNew_Click(object sender, EventArgs e)
        {
            //ABM DE MARCAS
            ABMmarcas marf = new ABMmarcas("tipo");
            marf.ShowDialog();


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            va =(Insumo) comboVajilla.SelectedItem;
            negocioInsumo.agregarVajillaXplato(PlatoLocal.id,Convert.ToInt32(va.id));
            cargarGrilla();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            
            if (dgvVajilla.CurrentRow != null)
            {
                VajillaXpla vaxpla = new VajillaXpla();
                vaxpla = (VajillaXpla)dgvVajilla.CurrentRow.DataBoundItem;
                negocioInsumo.DeleteVajillaXpla(vaxpla.idpla, vaxpla.idvaj);
                cargarGrilla();

            }
                
        }
    }
}
    

