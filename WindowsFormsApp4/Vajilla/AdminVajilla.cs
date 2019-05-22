using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Dominio;
using Negocio;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class AdminVajilla : Form
    {
        private List<Insumo> listarInsumoLocal;
        public AdminVajilla()
        {
            InitializeComponent();
        }
        // PROBANDO CAMBIO git hub
        private void AdminVajilla_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            this.AdminVajillaView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void cargarGrilla()
        { 
            // crea negocio para listar insumos
            VajillaNegocio negocio = new VajillaNegocio();

            try
            { //lista insumos
                listarInsumoLocal = negocio.listarInsumos();
                AdminVajillaView.DataSource = listarInsumoLocal;
                AdminVajillaView.Columns[0].Visible = false;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       public void cargarGrillaVajilla(string busqueda)
        {
            // crea negocio para listar insumos
            VajillaNegocio negocio = new VajillaNegocio();

            try
            { //lista insumos
                listarInsumoLocal = negocio.listarInsumos();
                AdminVajillaView.DataSource = listarInsumoLocal;
                AdminVajillaView.Columns[0].Visible = false;


                List<Insumo> lista;
                    lista = listarInsumoLocal.FindAll(X => X.Nombre.ToUpper().Contains(busqueda.ToUpper()));
                    AdminVajillaView.DataSource = lista;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AltaVajilla insumo = new AltaVajilla();
            insumo.ShowDialog();
            cargarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaVajilla modificar = new AltaVajilla((Insumo)AdminVajillaView.CurrentRow.DataBoundItem);
            modificar.ShowDialog();
            cargarGrilla();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                VajillaNegocio negocio = new VajillaNegocio();
                negocio.DeleteVajilla((Insumo)AdminVajillaView.CurrentRow.DataBoundItem);
                cargarGrilla();
            }
            
        }

        void ButBuscar_Click(object sender, EventArgs e)
        {
            Buscar search = new Buscar();
            search.ShowDialog();
            
            
        }
    }
}
