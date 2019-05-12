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
using AccesoDato;
using Dominio;
using Negocio;


namespace WindowsFormsApp4
{
    
    public partial class Carta : Form
    {
        AltaPlato plato = new AltaPlato();
        AltaPlato platoMod = new AltaPlato();
        SqlConsultas sql = new SqlConsultas();
        

        public Carta()
        {
            
            InitializeComponent();
        }

        private void Carta_Load(object sender, EventArgs e)
        {
            dgb.DataSource = sql.MostrarDatos();
            dgb.CurrentCell.Selected = false;
          
        }    

        private void button3_Click(object sender, EventArgs e)
        { }
          



        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            DataGridViewRow fila = dgb.Rows[e.RowIndex];
            platoMod.idLabel.Text = Convert.ToString(fila.Cells[0].Value);
            platoMod.txtNombrePla.Text = Convert.ToString(fila.Cells[1].Value);
            platoMod.txtPrecioPla.Text = Convert.ToString(fila.Cells[2].Value);
            platoMod.comboBoxPla.Text = Convert.ToString(fila.Cells[3].Value);

            
        }

        private void dgb_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void Carta_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgb.CurrentCell.ColumnIndex==0)
            {
                MessageBox.Show("No hay celdas seleccionadas!! Asegurece de seleccionar una celda.");
            }
            else { platoMod.Show(); }
            
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            
            
            plato.Show();
        }

        private void Carta_Deactivate(object sender, EventArgs e)
        {

        }

        private void butRefesh_Click(object sender, EventArgs e)
        {
            dgb.DataSource = sql.MostrarDatos();
        }

        private void dgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
    }
        

