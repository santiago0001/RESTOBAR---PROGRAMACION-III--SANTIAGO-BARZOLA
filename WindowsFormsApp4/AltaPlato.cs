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
using AccesoDato;
using System.Data.SqlClient;
using WindowsFormsApp4;


namespace Negocio
{
    public partial class AltaPlato : Form
    {
        SqlConsultas sql = new SqlConsultas();
        SqlConsultasCarta sqlCar = new SqlConsultasCarta();
        public AltaPlato()
        {
            InitializeComponent();
           
        }
        public AltaPlato(string id)
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string id = idLabel.Text;
            if (id.Equals("nuevo"))
            {
                if (sqlCar.Insertar(txtNombrePla.Text, txtPrecioPla.Text, comboBoxPla.Text, chktenedor.Checked.ToString(), chkCuchillo.Checked.ToString(), chkCuchara.Checked.ToString()))
                {
                    MessageBox.Show("Datos insertados");
                   // this.Close();

                }
                else MessageBox.Show("No se han podido insertar los datos");
                

            }
            else
            {
                string cadena = txtPrecioPla.Text;

                string[] partes = cadena.Split(',');

                if (sqlCar.Actualizar(idLabel.Text , txtNombrePla.Text , partes[0], comboBoxPla.Text, chktenedor.Checked.ToString(), chkCuchillo.Checked.ToString(), chkCuchara.Checked.ToString()))
                {
                    MessageBox.Show("Datos actualizados");
                    this.Hide();
                    //this.Close();
                }
                else MessageBox.Show("No se han podido actualizar los datos");
            }
            

        }

        private void AltaPlato_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPrecioPla_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

