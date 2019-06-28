using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WindowsFormsApp4
{
    public partial class Login : Form
    {
        EmpleadosNegocio negoem = new EmpleadosNegocio();

        public Login()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontra.Text != "")
            {
                if (negoem.LoginMaster(txtusuario.Text,txtcontra.Text))
                {
                    Principal prin = new Principal();
                    prin.ShowDialog();
                }
                else
                {
                    labError.ForeColor = Color.Red;
                    labError.Text = "USUARIO O CONTRASEÑA INCORRECTOS";
                }

            }
        }
    }
}
