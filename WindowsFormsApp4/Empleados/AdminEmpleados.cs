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
using Dominio;
using WindowsFormsApp4.Bebidas;

namespace WindowsFormsApp4.Empleados
{
    public partial class AdminEmpleados : Form
    {
        public AdminEmpleados()
        {
            InitializeComponent();
        }
        EmpleadosNegocio negocioEm = new EmpleadosNegocio();
        private List<Empleado> listaEmpleados;
        private void AdminEmpleados_Load(object sender, EventArgs e)
        {
               dgvEmp.CurrentCell = null;
            cargarGrilla();
            this.dgvEmp.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }
        void cargarGrilla()
        {
            // crea negocio para listar insumos

            try
            { //lista insumos
                listaEmpleados = negocioEm.listarEmpleado();
                dgvEmp.DataSource = listaEmpleados;
                //Ocultar columnas
                dgvEmp.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;
                dgvEmp.Columns["id"].Visible = false;
                dgvEmp.Columns["estado"].Visible = false;
                dgvEmp.Columns["contraseña"].Visible = false;












            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            ABMempleados emp = new ABMempleados();
            emp.ShowDialog();
            cargarGrilla();
        }

        private void ButMod_Click(object sender, EventArgs e)
        {
            ABMempleados emp = new ABMempleados((Empleado)dgvEmp.CurrentRow.DataBoundItem);
            emp.ShowDialog();
            cargarGrilla();
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmp.CurrentRow != null)
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {

                    negocioEm.DeleteEmpleado((Empleado)dgvEmp.CurrentRow.DataBoundItem);
                    MessageBox.Show("Podras buscarlo en la papelera de reciclaje");
                    cargarGrilla();



                }
            }
            else
            {
                MessageBox.Show("No hay empledos para eliminar");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Papelera pap = new Papelera("empleado");
            pap.ShowDialog();
            cargarGrilla();
        }
    }

}