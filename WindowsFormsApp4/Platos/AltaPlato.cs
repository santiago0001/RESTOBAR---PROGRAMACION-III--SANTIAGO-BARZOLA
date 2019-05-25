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

        private void LlenarComboTipo()
        {

            ListaTipoPlatosLocal = negocio.listarTipoPlato();
            comboBoxPla.DataSource = null;
            comboBoxPla.DataSource = ListaTipoPlatosLocal;
            comboBoxPla.DisplayMember = "nombre";
            comboBoxPla.ValueMember = "id";
        }


        private void AltaPlato_Load(object sender, EventArgs e)
        {
            ListaTipoPlatosLocal = negocio.listarTipoPlato();
            dgvTipo.DataSource = ListaTipoPlatosLocal;
            LlenarComboTipo();

            if (PlatoLocal != null)
            {
                txtNombrePla.Text = PlatoLocal.Nombre;
                idLabel.Text = PlatoLocal.id.ToString();
                txtPrecioPla.Text = PlatoLocal.Precio.ToString(); 

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

            ABMmarcas marf = new ABMmarcas("tipo");
            marf.ShowDialog();


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
    

