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

namespace WindowsFormsApp4
{
    public partial class Asignacion : Form
    {
        public Asignacion()
        {
            InitializeComponent();
        }

        EmpleadosNegocio negoEm = new EmpleadosNegocio();
        List<Empleado> ListaMeserosLocal;
        Empleado MeseroLocal = new Empleado();
        List<Empleado> ListaActivos;


        MesaNegocio negome = new MesaNegocio();
        List<Mesa> ListaMesaLocal;
        Mesa mesaLocal = new Mesa();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Asignacion_Load(object sender, EventArgs e)
        {
            ListaActivos = negoEm.listarMeseros();

            if (ListaActivos.Count == 0)
            {
                MessageBox.Show("No tiene meseros activos, de de alta un mesero para asignar a las mesas", " Error");
                this.Close();
            }
            else { 
            dgvmesa.CurrentCell = null;
            cargarGrilla();
            this.dgvmesa.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            LlenarComboMeseros();
            limpiar();
            }
        }

        private void cargarGrilla()
        {
            Random random = new Random();

            ListaMesaLocal = negome.listarMesa();
            ListaMeserosLocal = negoEm.listarEmpleadoTotal();
            //recorro las mesas para bucar si hay algun empleado que este dado de baja con una mesa asignada
            // en caso de encontrarlo le asigno un empleado activo a la mesa
           for (int i=0;i<ListaMesaLocal.Count;i++)
            {
                for (int x = 0; x < ListaMeserosLocal.Count; x++)
                {
                    if (ListaMesaLocal[i].IdMesero== ListaMeserosLocal[x].Id)
                    {

                       if  (!ListaMeserosLocal[x].Estado)
                        {
                            int randomNumber = random.Next(0, ListaActivos.Count);
                            negome.modificarMesero(ListaMesaLocal[i], ListaActivos[randomNumber]);
                        }

                    }

                }


            }
            ListaMesaLocal = negome.listarMesa();
            dgvmesa.DataSource = ListaMesaLocal;
            dgvmesa.Columns["IdMesero"].Visible = false;
            dgvmesa.Columns["estado"].Visible = false;
            dgvmesa.Columns["ocupado"].Visible = false;
            dgvmesa.Columns["NomApe"].HeaderText = "Nombre y apellido";
            dgvmesa.Columns["IdMesa"].HeaderText = "N° Mesa";
            dgvmesa.Columns["stOcupado"].HeaderText = "Estado";



        }
        private void LlenarComboMeseros()
        {

            ListaMeserosLocal = negoEm.listarMeseros();
            comboMese.DataSource = null;
            comboMese.DataSource = ListaMeserosLocal;
            comboMese.DisplayMember = "Nombre";
            comboMese.ValueMember = "id";
            comboMese.Text = "Seleccionar mesero";
        }

        private void ComboMese_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboOrdenar();
        }

        private void comboOrdenar()
        {

            MeseroLocal = (Empleado)comboMese.SelectedItem;
            //parto el apellido y nombre en dos
            string nom_ape = MeseroLocal.Nombre;
            string[] nombre;
            nombre = nom_ape.Split(',');

            txtNombre.Text = nombre[0];
            txtApe.Text = nombre[1];
            txtdni.Text = Convert.ToString(MeseroLocal.Dni);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboMese.Text != "Seleccionar mesero")
            {
                negome.agregarMesa((Empleado)comboMese.SelectedItem);
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un mesero para la mesa", "Error de mesero");
            }
            dgvmesa.ClearSelection();

        }

        private void Dgvmesa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvmesa.Columns[e.ColumnIndex].Name == "stOcupado")
            {
                if (e.Value.ToString() == "Ocupado")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;


                }
                else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        void limpiar()
        {
            dgvmesa.ClearSelection();
            comboMese.Text = "Seleccionar mesero";
            txtNombre.Text = "";
            txtApe.Text = "";
            txtdni.Text = "";
            labelmesa.Text = "";

        }

        private void Asignacion_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void Dgvmesa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mesaLocal = (Mesa)dgvmesa.CurrentRow.DataBoundItem;
            int aux = -1;
            for (int i = 0; i < ListaMeserosLocal.Count; i++)
            {
                if (ListaMeserosLocal[i].Id == mesaLocal.IdMesero)
                {
                    aux = i;
                    i = ListaMeserosLocal.Count;
                }
            }
            comboMese.SelectedIndex = comboMese.FindString(ListaMeserosLocal[aux].Nombre);
            comboMese.Text = ListaMeserosLocal[aux].Nombre;
            comboOrdenar();
            labelmesa.Text = "Mesa"+ mesaLocal.IdMesa.ToString();
            

        }

        private void ComboMese_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            negome.modificarMesero(mesaLocal,MeseroLocal);
            cargarGrilla();
            MessageBox.Show("Modificado con exito!");
            limpiar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (dgvmesa.CurrentRow != null)
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {

                    negome.DeleteMesa(mesaLocal = (Mesa)dgvmesa.CurrentRow.DataBoundItem);
                    MessageBox.Show("Podras buscarlo en la papelera de reciclaje");
                    cargarGrilla();



                }
            }
            else
            {
                MessageBox.Show("No hay bebidas para seleccionar");
            }


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Papelera pap = new Papelera("mesa");
            pap.ShowDialog();
            cargarGrilla();
        }
    }
}
