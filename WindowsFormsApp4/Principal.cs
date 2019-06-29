using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Bebidas;
using WindowsFormsApp4.Empleados;
using System.Windows.Forms.DataVisualization.Charting;
using Dominio;
using Negocio;
namespace WindowsFormsApp4
{
    public partial class Principal : Form
    {
        List<DiaEstadistica> listaDias;
        List<EmpleadoEstadistica> ListaEmpleado;
        List<PlatoEstadistica> listaPlatoEst;
        Estadisticas negoest = new Estadisticas();
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
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
            VajillaMesero frm = new VajillaMesero();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            AdminBebidas BebidasForm = new AdminBebidas();
            BebidasForm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }



        private void loadFecha(bool error)
        {
            if (error==false)
            {
                label3.ForeColor = Color.Black;
                label3.Text = "Desde el" + dateDesde.Value.Date.ToString("dd/MM/yyyy") + " hasta el "
                        + dateHasta.Value.Date.ToString("dd/MM/yyyy");
            }
            else
            {
                label3.Text = "LA FECHA 'DESDE' TIENE QUE SER MENOR QUE 'HASTA' ";
                label3.ForeColor = Color.Red;
            }
            
        }
        Login f1 = Application.OpenForms.OfType<Login>().SingleOrDefault();

        private void Principal_Load(object sender, EventArgs e)
        {

            f1.Visible=false;

            dateDesde.Value = DateTime.Today.AddDays(-7);
            loadFecha(false);

            btnPedidosxEm.Enabled = false;
            RecargarCharts();
            btnPedidosxEm.Enabled = false;
            chart1.Visible = false;
            ChPed.Visible = true;
            btnPlatoPop.Enabled = true;
            btnDias.Enabled = true;
            chart2.Visible = false;
        }

        private void AdministracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RecargarCharts()
        {

            ListaEmpleado = negoest.listaEmpleadosCan(dateDesde.Value.Date.ToString("yyyy/MM/dd"),
            dateHasta.Value.Date.ToString("yyyy/MM/dd"));
            ChPed.ChartAreas[0].AxisY.Maximum = ListaEmpleado[0].CantidadPlatos +20;

            ChPed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            ChPed.Titles.Add("PEDIDOS POR MESERO");
            for (int i = 0; i < ListaEmpleado.Count; i++)
            {

                Series serie = ChPed.Series.Add(ListaEmpleado[i].Nombre+", DNI:"+ ListaEmpleado[i].Dni);
                serie.Label = ListaEmpleado[i].CantidadPlatos.ToString();
                serie.Points.Add(ListaEmpleado[i].CantidadPlatos);

            }




            listaPlatoEst = negoest.ListarPlatoEst(dateDesde.Value.Date.ToString("yyyy/MM/dd"),
            dateHasta.Value.Date.ToString("yyyy/MM/dd"));
            chart1.ChartAreas[0].AxisY.Maximum = listaPlatoEst[0].Cantidad + 10;

            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            chart1.Titles.Add("PLATOS MAS PEDIDOS");

            for (int i = 0; i < listaPlatoEst.Count; i++)
            {
                Series serie1 = new Series();
                    serie1 = chart1.Series.Add(listaPlatoEst[i].Nombre);
                serie1.Label = listaPlatoEst[i].Cantidad.ToString();
                serie1.Points.Add(listaPlatoEst[i].Cantidad);
            }
            //btnPlatoPop.Enabled = false;
            //btnPedidosxEm.Enabled = true;


            listaDias = negoest.ListarDiasEst();
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            chart2.Titles.Add("RECAUDACION DE DIAS DEL MES");

            for (int i = 0; i < listaDias.Count; i++)
            {
                Series serie1 = chart2.Series.Add(listaDias[i].Dia.ToString());
                serie1.Label = "$" + listaDias[i].Recaudacion.ToString();
                serie1.Points.Add(Convert.ToDouble(listaDias[i].Recaudacion));
            }
            
        }


        private void AdministacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignacion form3 = new Asignacion();

            form3.MdiParent = this.MdiParent;

            form3.Show();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminEmpleados empForm = new AdminEmpleados();
            empForm.ShowDialog();
        }

        private void PlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carta frm = new Carta();

            frm.Show();
        }

        private void BebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdminBebidas frm = new AdminBebidas();
            frm.Show();
        }

        private void VajillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminVajilla frm = new AdminVajilla();
            frm.Show();
        }

        private void BtnPedidosxEm_Click(object sender, EventArgs e)
        {
            btnPedidosxEm.Enabled = false;
            chart1.Visible = false;
            ChPed.Visible = true;
            btnPlatoPop.Enabled = true;
            btnDias.Enabled = true;
            chart2.Visible = false;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            btnPlatoPop.Enabled = false;
            chart1.Visible = true;
            ChPed.Visible = false;
            btnPedidosxEm.Enabled = true;
            btnDias.Enabled = true;
            chart2.Visible = false;
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            btnDias.Enabled = false; chart2.Visible = true;
            chart1.Visible = false; btnPlatoPop.Enabled = true;
            ChPed.Visible = false; btnPedidosxEm.Enabled = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            
            if (dateHasta.Value>dateDesde.Value)
            {
                loadFecha(false);
                ChPed.Series.Clear();
                ChPed.Titles.Clear();
                chart1.Series.Clear();
                chart1.Titles.Clear();

                chart2.Series.Clear();
                chart2.Titles.Clear();

                RecargarCharts();
                
            }
            else
            {

                loadFecha(true);
            }
            
        }

        private void Chart2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            f1.Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            btnDias.Enabled = false; chart2.Visible = true;
                chart1.Visible = false; btnPlatoPop.Enabled = true;
                ChPed.Visible = false; btnPedidosxEm.Enabled = true;
        }
    }
    }

