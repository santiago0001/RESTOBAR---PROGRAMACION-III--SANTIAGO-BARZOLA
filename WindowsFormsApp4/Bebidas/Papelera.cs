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
    public partial class Papelera : Form
    {
        // si no pasan bebida necesitamos listas y bebidas local para manejarlo
        private List<Bebida> listarBebidaLocal;
        BebidasNegocio negocio = new BebidasNegocio();
        private Bebida BebidaLocal = null;

        //marcas 
        private List<Marca> listarMarcaLocal;
        MarcaNegocio negocioMar = new MarcaNegocio();
        private Marca MarcaLocal = null;

        // si es una bebida en el codigo pasamos por string 'bebida' para manejar la papelera como tal
        string Clave;

        public Papelera()
        {
            InitializeComponent();
        }

        // constructor 
        public Papelera(string clave)
        {
            InitializeComponent();
            Clave = clave;
        }


        private void Papelera_Load(object sender, EventArgs e)
        {
            // le ponemos modo de seleccion de todo la fila
            this.dgvPapelera.SelectionMode =
              DataGridViewSelectionMode.FullRowSelect;
            
            
            // cargamos la grilla
            cargarGrilla();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void cargarGrilla()
        {
            try
            {
                // si es bebida
                if (Clave.StartsWith("bebida"))
                {
                    listarBebidaLocal = negocio.listarBebidasEliminadas();
                    dgvPapelera.DataSource = listarBebidaLocal;
                    dgvPapelera.Columns["id"].Visible = false;
                    dgvPapelera.Columns["Estado"].Visible = false;
                    dgvPapelera.Columns["copa"].Visible = false;
                    dgvPapelera.Columns["nombre"].DisplayIndex = 0;
                    dgvPapelera.Columns["nombre"].Width = 140;
                    dgvPapelera.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;
                    dgvPapelera.Columns["descripcion"].DisplayIndex = 1;
                    dgvPapelera.Columns["descripcion"].Width = 170;

                    dgvPapelera.Columns["marca"].DisplayIndex = 2;
                    dgvPapelera.Columns["precio"].DisplayIndex = 3;
                    dgvPapelera.Columns["cantidad"].DisplayIndex = 4;
                }
                if (Clave.StartsWith("marca"))
                {
                    listarMarcaLocal = negocioMar.listarMarcasEliminadas();
                    dgvPapelera.DataSource = listarMarcaLocal;
                    dgvPapelera.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;
                    dgvPapelera.Columns["id"].Visible = false;
                   // dgvPapelera.Columns["estado"].Visible = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void BotRestaurar_Click(object sender, EventArgs e)
        {
            // si es bebida
            if (Clave.StartsWith("bebida"))
            {
                BebidaLocal = null;

                // si tengo una fila seleccionada
            if (dgvPapelera.CurrentRow != null) { 
                BebidaLocal = (Bebida)dgvPapelera.CurrentRow.DataBoundItem;
                negocio.RestaurarBebida(BebidaLocal);
                    MessageBox.Show("Restaurado con exito");
                cargarGrilla();
                }  else { MessageBox.Show("No hay elementos para retaurar"); }
            
            }
            else if (Clave.StartsWith("marca"))
            {
               // MarcaLocal = null;
                // si tengo una fila seleccionada
                if (dgvPapelera.CurrentRow != null)
                {
                    MarcaLocal = (Marca)dgvPapelera.CurrentRow.DataBoundItem;
                    negocioMar.RestaurarMarca(MarcaLocal);
                    MessageBox.Show("Restaurado con exito");
                    cargarGrilla();
                }
                else { MessageBox.Show("No hay elementos para retaurar"); }

            }

        }
    }
}
