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
using Dominio;
using Negocio;


namespace WindowsFormsApp4
{
    public partial class Vajilla : Form
    {
        private List<Insumo> ListaInsumoLocal;
        public Vajilla()
        {
            InitializeComponent();
        }

        private void Vajilla_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void butAdd_Click(object sender, EventArgs e)
        {
        }
        private void cargarGrilla()
        {
            VajillaNegocio negocio = new VajillaNegocio();
            try
            {
                ListaInsumoLocal = negocio.listarInsumos();
                vajilladata.DataSource = ListaInsumoLocal;
                vajilladata.Columns[0].Visible = false;
                vajilladata.Columns[1].Visible = false;
                //dgvPersonajes.Columns[4].Visible = false;
                //dgvPersonajes.Columns[5].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaInsumo insumo = new AltaInsumo();
            insumo.ShowDialog();
            cargarGrilla();
        }
    }
}
