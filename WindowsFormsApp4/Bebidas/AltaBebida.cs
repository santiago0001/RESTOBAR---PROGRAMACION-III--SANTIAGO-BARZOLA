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
    public partial class AltaBebida : Form
    {
        private Bebida BebidaLocal=null;
        private List<Marca> ListarMarcaLocal;
        public AltaBebida()
        {
            InitializeComponent();
        }
        public AltaBebida(Bebida beb)
        {
            InitializeComponent();
            BebidaLocal = beb;
        }

        private void ButAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.BackColor = Color.Salmon;

                MessageBox.Show("Debe completar el nombre");

            }
                                                         

            else
            {
                BebidasNegocio negocio = new BebidasNegocio();

                // si es nuevo
                if (BebidaLocal == null)
                    BebidaLocal = new Bebida();

                if (txtCant.Text == "")
                { txtCant.Text = "0"; }

                
                BebidaLocal.Nombre = txtNombre.Text;
                BebidaLocal.marca= (Marca)comboMar.SelectedItem;
                BebidaLocal.Descripcion = txtDescrip.Text;
                BebidaLocal.Precio = Convert.ToDecimal(txtPrecio.Text);
                BebidaLocal.Cantidad = Convert.ToInt32(txtCant.Text);
                BebidaLocal.Copa = radioCopa.Checked;
                

                // BebidaLocal.marca.Id = comboMar.ValueMember
                BebidaLocal.Cantidad = Convert.ToInt32(txtCant.Text);

                //si es existente 
                if (BebidaLocal.id != 0)
                {
                    negocio.modificarInsumo(BebidaLocal);
                }
                // si es nuevo
                else
                {
                    negocio.agregarBebida(BebidaLocal);
                }

                Close();
            }
        }

        private void AltaBebida_Load(object sender, EventArgs e)
        {
            LlenarComboMarcas();

            if (BebidaLocal != null)
            {
                labelID.Text = BebidaLocal.id.ToString();
                txtNombre.Text = BebidaLocal.Nombre;
                txtDescrip.Text = BebidaLocal.Descripcion;
                txtPrecio.Text = Convert.ToString(BebidaLocal.Precio);
                txtCant.Text = BebidaLocal.Cantidad.ToString();
                radioCopa.Checked = BebidaLocal.Copa;
                if (radioCopa.Checked==false) { radioVaso.Checked = true; }
                comboMar.SelectedIndex = comboMar.FindString(BebidaLocal.marca.Nombre);

            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }
        private void LlenarComboMarcas() { 

        MarcaNegocio negocio = new MarcaNegocio();
        ListarMarcaLocal = negocio.listarMarcas();
            comboMar.DataSource = null;
            comboMar.DataSource = ListarMarcaLocal;
            comboMar.DisplayMember = "Nombre";
            comboMar.ValueMember = "Id";
        }

        private void BotNewMar_Click(object sender, EventArgs e)
        {
            ABMmarcas mar = new ABMmarcas("marca");
            mar.ShowDialog();
            LlenarComboMarcas();
        }
    }
}
