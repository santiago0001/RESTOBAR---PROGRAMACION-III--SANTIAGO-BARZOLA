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

namespace WindowsFormsApp4.Empleados
{
    public partial class ABMempleados : Form
    {
        Empleado EmpleadoLocal = new Empleado();
        EmpleadosNegocio negocioEm = new EmpleadosNegocio();

        public ABMempleados()
        {
            InitializeComponent();
        }
        public ABMempleados(Empleado em)
        {
            
            InitializeComponent();
            EmpleadoLocal = em;
        }
        bool ban = false;
        private void ABMempleados_Load(object sender, EventArgs e)
        {
            
            labelID.Text = "Nuevo";

            if (EmpleadoLocal!=null)

            {
                if (EmpleadoLocal.Id==0)
                {
                    
                }
                else
                {
                    ban = true;
                    txtNombre.Text = EmpleadoLocal.Nombre;
                txtApe.Text = EmpleadoLocal.Apellido;
                txtUs.Text = EmpleadoLocal.Usuario;
                txtCon.Text = EmpleadoLocal.Contraseña;
                txtDni.Text = EmpleadoLocal.Dni.ToString();
                labelID.Text = EmpleadoLocal.Id.ToString();
                comboPues.SelectedIndex = comboPues.FindString(EmpleadoLocal.Puesto);
                }


            }
            else
            {
                
                comboPues.SelectedValue = 1;
            }
                


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                labError.Text = "Te falta el nombre";
            }
            else if (txtApe.Text == "")
            {
                labError.Text = "Te falta el apellido";
            }
            else if (txtDni.Text == "")
            {
                labError.Text = "Te falta el DNI";
            }
            else if (txtUs.Text == "")
            {
                labError.Text = "Te falta el usuario";
            }
            else if (txtCon.Text == "")
            {
                labError.Text = "Te falta contrasena";
            }

            else {

                if (negocioEm.ChequeoDNI(Convert.ToInt32(txtDni.Text),ban) == true || Convert.ToInt32(txtDni.Text)==0 )
                {
                    labError.Text = "El dni existe";
                }
                else { 
                EmpleadoLocal.Nombre = txtNombre.Text;
            EmpleadoLocal.Apellido = txtApe.Text;
            EmpleadoLocal.Usuario = txtUs.Text;
            EmpleadoLocal.Contraseña = txtCon.Text ;
            if (EmpleadoLocal.Puesto == null)
            {
                EmpleadoLocal.Puesto = "Mesero";
            }
            else
            {
                EmpleadoLocal.Puesto = comboPues.SelectedItem.ToString();
            }
           
            

            EmpleadoLocal.Dni =Convert.ToInt32( txtDni.Text);


            if (EmpleadoLocal.Id == 0) {
            negocioEm.agregarEmpleado(EmpleadoLocal);
            }
            else
            {
                negocioEm.modificarEmpleado(EmpleadoLocal);
            }

            Close();
                }
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
