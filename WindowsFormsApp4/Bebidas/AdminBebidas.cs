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
    public partial class AdminBebidas : Form
    {
        private List<Bebida> listarBebidaLocal;
        BebidasNegocio negocio = new BebidasNegocio();

        public AdminBebidas()
        {
            InitializeComponent();
        }

        private void AdminBebidas_Load(object sender, EventArgs e)
        {
            DgvBebidas.CurrentCell = null;
            cargarGrilla();
            this.DgvBebidas.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

        }
        void cargarGrilla()
        {
            // crea negocio para listar insumos

            try
            { //lista insumos
                listarBebidaLocal = negocio.listarBebidas();
                DgvBebidas.DataSource = listarBebidaLocal;
                //Ocultar columnas
                    DgvBebidas.Columns["id"].Visible = false;
                DgvBebidas.Columns["Estado"].Visible = false;
                DgvBebidas.Columns["copa"].Visible = false;
                  DgvBebidas.Columns["nombre"].DisplayIndex = 0;
                DgvBebidas.Columns["nombre"].Width = 140;
                DgvBebidas.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;
                DgvBebidas.Columns["descripcion"].DisplayIndex = 1;
                DgvBebidas.Columns["descripcion"].Width = 170;
                DgvBebidas.Columns["precio"].Visible = false;

                DgvBebidas.Columns["marca"].DisplayIndex = 2;
                DgvBebidas.Columns["precio"].DisplayIndex = 3;
                DgvBebidas.Columns["cantidad"].DisplayIndex = 4;

                









            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

     public   void cargarGrilla(string busqueda)
        {
            // crea negocio para listar insumos

            try
            { //lista insumos
                listarBebidaLocal = negocio.listarBebidas();
                DgvBebidas.DataSource = listarBebidaLocal;
                //Ocultar columnas
                DgvBebidas.Columns["id"].Visible = false;
                DgvBebidas.Columns["Estado"].Visible = false;
                DgvBebidas.Columns["copa"].Visible = false;
                DgvBebidas.Columns["nombre"].DisplayIndex = 0;
                DgvBebidas.Columns["nombre"].Width = 140;
                DgvBebidas.Columns["nombre"].DefaultCellStyle.BackColor = Color.GreenYellow;
                DgvBebidas.Columns["descripcion"].DisplayIndex = 1;
                DgvBebidas.Columns["descripcion"].Width = 170;
                DgvBebidas.Columns["precio"].Visible = false;

                DgvBebidas.Columns["marca"].DisplayIndex = 2;
                DgvBebidas.Columns["precio"].DisplayIndex = 3;
                DgvBebidas.Columns["cantidad"].DisplayIndex = 4;



                List<Bebida> lista;
                lista = listarBebidaLocal.FindAll(X => X.Nombre.ToUpper().Contains(busqueda.ToUpper()));
                DgvBebidas.DataSource = lista;







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void DgvBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotAdd_Click(object sender, EventArgs e)
        {
            AltaBebida beb = new AltaBebida();
            beb.ShowDialog();
            cargarGrilla();

        }

        private void BotMod_Click(object sender, EventArgs e)
        {
            AltaBebida beb = new AltaBebida((Bebida)DgvBebidas.CurrentRow.DataBoundItem);
            beb.ShowDialog();
            cargarGrilla();
        }

        private void BotElim_Click(object sender, EventArgs e)
        {
            if (DgvBebidas.CurrentRow != null)
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {

                    negocio.DeleteBebida((Bebida)DgvBebidas.CurrentRow.DataBoundItem);
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
            Papelera eliminados = new Papelera("bebida");
            eliminados.ShowDialog();
            cargarGrilla();
        }

        private void BotBus_Click(object sender, EventArgs e)
        {
            Buscar bus = new Buscar("bebida");
            bus.ShowDialog();
            cargarGrilla();
        }
    }
}
