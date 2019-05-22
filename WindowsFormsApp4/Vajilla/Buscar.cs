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

namespace WindowsFormsApp4
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }
       
        public List<Insumo> BusquedaInsumos(List<Insumo> listarInsumoLocal)
        {
            if (Searchtxt.Text == "")
            {
                return listarInsumoLocal;
            }
            else
            {
                List<Insumo> lista;
                lista = listarInsumoLocal.FindAll(X => X.Nombre.Contains(Searchtxt.Text));
                listarInsumoLocal = lista;
            }

            return listarInsumoLocal;
        }
       
        private void Buscar_Load(object sender, EventArgs e)
        {

        }


        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminVajilla f1 = Application.OpenForms.OfType<AdminVajilla>().SingleOrDefault();

            f1.cargarGrillaVajilla(Searchtxt.Text);
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
