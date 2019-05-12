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
    public partial class AltaInsumo : Form
    {
        private Insumo InsumoLocal = null;
        public AltaInsumo()
        {
            InitializeComponent();
        }
        public AltaInsumo(Insumo insum)
        {
            InitializeComponent();
            InsumoLocal = insum;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VajillaNegocio negocio = new VajillaNegocio();

            // si es nuevo
            if (InsumoLocal == null)
                InsumoLocal = new Insumo();
            if (txtPrecio.Text == "")
            { txtPrecio.Text = "0"; }

            if (txtCant.Text == "")
            { txtCant.Text = "0"; }

            // si es existente
            InsumoLocal.Nombre = txtNombre.Text;
            InsumoLocal.Cantidad = Convert.ToInt32(txtCant.Text);
            InsumoLocal.Precio = Convert.ToDecimal(txtPrecio.Text);
            InsumoLocal.Tipo = comboBox1.Text;

            //si es existente 
            if (InsumoLocal.id != 0)
            {
                negocio.modificarInsumo(InsumoLocal);
            }
            // si es nuevo
            else
            {
                negocio.agregarVajilla(InsumoLocal);
            }

            Close();
        }

        private void AltaInsumo_Load(object sender, EventArgs e)
        {
            if (InsumoLocal != null)
            {
                txtNombre.Text = InsumoLocal.Nombre;
                LabID.Text = InsumoLocal.id.ToString();
                txtCant.Text = InsumoLocal.Cantidad.ToString();
                txtPrecio.Text = InsumoLocal.Precio.ToString();
                comboBox1.Text = InsumoLocal.Tipo.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
            }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
