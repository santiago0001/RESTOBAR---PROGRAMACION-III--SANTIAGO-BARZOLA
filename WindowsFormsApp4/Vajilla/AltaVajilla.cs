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
    public partial class AltaVajilla : Form
    {
        private Insumo InsumoLocal = null;
        public AltaVajilla()
        {
            InitializeComponent();
        }
        public AltaVajilla(Insumo insum)
        {
            InitializeComponent();
            InsumoLocal = insum;
        }
        //aceptar
        private void button1_Click(object sender, EventArgs e)
        { // cambiar color y avisar que no lleno campos
          
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    txtNombre.BackColor = Color.Salmon;
                    
                    MessageBox.Show("Debe completar el nombre");

                }

    


            else { 
        VajillaNegocio negocio = new VajillaNegocio();

            // si es nuevo
            if (InsumoLocal == null)
                InsumoLocal = new Insumo();

            if (txtCant.Text == "")
            { txtCant.Text = "0"; }

            
            InsumoLocal.Nombre = txtNombre.Text;
            InsumoLocal.Cantidad = Convert.ToInt32(txtCant.Text);

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
        }

        //Cargar form segun alta o modificacion
        private void AltaInsumo_Load(object sender, EventArgs e)
        {
            if (InsumoLocal != null)
            {
                txtNombre.Text = InsumoLocal.Nombre;
                LabID.Text = InsumoLocal.id.ToString();
                txtCant.Text = InsumoLocal.Cantidad.ToString();
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
