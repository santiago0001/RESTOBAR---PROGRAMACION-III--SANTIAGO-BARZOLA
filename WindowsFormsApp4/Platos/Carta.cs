using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AccesoDatos;
using WindowsFormsApp4.Bebidas;
using Dominio;
using Negocio;


namespace WindowsFormsApp4
{
    
    public partial class Carta : Form
    {
       
        public Carta()
        {
            
            InitializeComponent();
        }

        private List<Plato> listarPlatoLocal;
        private void Carta_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            this.dgvCarta.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        void cargarGrilla()
        {
            // crea negocio para listar insumos
            PlatoNegocio negocio = new PlatoNegocio();

            try
            { //lista insumos
                listarPlatoLocal = negocio.listarPlatos();
                dgvCarta.DataSource = listarPlatoLocal;
                dgvCarta.Columns["id"].Visible = false;
                dgvCarta.Columns["cantidad"].Visible = false;
                dgvCarta.Columns["estado"].Visible = false;
                dgvCarta.Columns["nombre"].DisplayIndex = 0;
                dgvCarta.Columns["descripcion"].DisplayIndex = 1;
                dgvCarta.Columns["precio"].DisplayIndex = 2;
                dgvCarta.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { }
          



        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
          
            
        }

        private void dgb_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void Carta_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaPlato plato = new AltaPlato((Plato)dgvCarta.CurrentRow.DataBoundItem);
            plato.ShowDialog();
            cargarGrilla();
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            AltaPlato plato = new AltaPlato();
            plato.ShowDialog();
            cargarGrilla();
          
        }

        private void Carta_Deactivate(object sender, EventArgs e)
        {

        }

        private void butRefesh_Click(object sender, EventArgs e)
        {
            
        }

        private void dgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                PlatoNegocio negocio = new PlatoNegocio();
                negocio.DeletePlato((Plato)dgvCarta.CurrentRow.DataBoundItem);
                cargarGrilla();
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Papelera pap = new Papelera("plato");
            pap.ShowDialog();
            cargarGrilla();
        }
    }

    
    }
        

