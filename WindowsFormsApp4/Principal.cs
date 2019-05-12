using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Asignacion frm = new Asignacion();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Salones frm = new Salones();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Carta frm = new Carta();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargaPedido frm = new CargaPedido();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mesas frm = new Mesas();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vajilla frm = new Vajilla();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminVajilla frm = new AdminVajilla();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Cobro frm = new Cobro();
            frm.Show();
        }
    }
    }

