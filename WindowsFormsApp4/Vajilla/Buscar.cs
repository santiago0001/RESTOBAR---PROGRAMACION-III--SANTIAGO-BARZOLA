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
using WindowsFormsApp4.Bebidas;

namespace WindowsFormsApp4
{
    public partial class Buscar : Form
    {
        string Clave;
        public Buscar(string clave)
        {
            InitializeComponent();
            Clave = clave;
        }
      
       
        private void Buscar_Load(object sender, EventArgs e)
        {

        }


        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clave == "vajilla") { 
            AdminVajilla f1 = Application.OpenForms.OfType<AdminVajilla>().SingleOrDefault();

            f1.cargarGrillaVajilla(Searchtxt.Text);
            }
            if (Clave=="bebida")
            {
                AdminBebidas f1 = Application.OpenForms.OfType<AdminBebidas>().SingleOrDefault();

                f1.cargarGrilla(Searchtxt.Text);
            }

        }

        private void Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
