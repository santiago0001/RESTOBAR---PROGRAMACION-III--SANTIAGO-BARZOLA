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

        // vajillas
        private List<Insumo> listarInsumoLocal;
        VajillaNegocio negocioIns = new VajillaNegocio();
        private Insumo InsumoLocal = null;

        // 
        private List<Plato> listarPlatoLocal;
        PlatoNegocio negocioPla = new PlatoNegocio();
        private Plato PlatoLocal = null;



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
                if (Clave.StartsWith("vajilla"))
                {
                    listarInsumoLocal = negocioIns.listarInsumosEliminados();
                    dgvPapelera.DataSource = listarInsumoLocal;
                    dgvPapelera.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;
                    dgvPapelera.Columns["estado"].Visible = false;
                    dgvPapelera.Columns["id"].Visible = false;

                }
                if (Clave=="plato")
                {
                    listarPlatoLocal = negocioPla.listarPlatosEliminados();
                    dgvPapelera.DataSource = listarPlatoLocal;
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
             if (Clave.StartsWith("marca"))
            {
               
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
            if (Clave.StartsWith("vajilla"))
            {
                // si tengo una fila seleccionada
                if (dgvPapelera.CurrentRow != null)
                {
                    InsumoLocal = (Insumo)dgvPapelera.CurrentRow.DataBoundItem;
                    negocioIns.RestaurarVajilla(InsumoLocal);
                    MessageBox.Show("Restaurado con exito");
                    cargarGrilla();
                }
                else { MessageBox.Show("No hay elementos para retaurar"); }


            }

            if (Clave == "plato")
            {
                if (dgvPapelera.CurrentRow != null)
                {
                    PlatoLocal = (Plato)dgvPapelera.CurrentRow.DataBoundItem;
                    negocioPla.RestaurarPlato(PlatoLocal);
                    MessageBox.Show("Restaurado con exito");
                    cargarGrilla();
                }
                else { MessageBox.Show("No hay elementos para retaurar"); }
            }


        }
    }
}
