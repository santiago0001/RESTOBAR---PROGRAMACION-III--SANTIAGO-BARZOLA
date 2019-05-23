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
using WindowsFormsApp4;


namespace Negocio
{
    public partial class AltaPlato : Form
    {
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
            

        

        private void AltaPlato_Load(object sender, EventArgs e)
        {
            if (PlatoLocal != null)
            {
                txtNombrePla.Text = PlatoLocal.Nombre;
                idLabel.Text = PlatoLocal.id.ToString();
                txtPrecioPla.Text = PlatoLocal.Precio.ToString();
                comboBoxPla.Text = PlatoLocal.Tipo.ToString();
 

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
    }
}
    

