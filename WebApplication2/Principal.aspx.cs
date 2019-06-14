using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        EmpleadosNegocio negocioEm = new EmpleadosNegocio();
        private List<Empleado> listaEmpleados;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                listaEmpleados = negocioEm.listarMeseros();
                DropDownList1.DataSource = null;
                DropDownList1.DataSource = listaEmpleados;
                DropDownList1.DataTextField = "Nombre";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                droplist();

            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        protected void droplist()
        {
            LabNombre.Text = DropDownList1.SelectedItem.ToString();
            Session["id"] = DropDownList1.SelectedItem.Value.ToString();
            Session["nomMesero"] = DropDownList1.SelectedItem.Text.ToString();

        }
        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {

            droplist();


            //Session["id"] = DropDownList1.SelectedItem.Text;



        }

        protected void ButPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mesapagg.aspx");
        }

        protected void ButPedido_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/mesapagg.aspx");
        }

        protected void btnLiberar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Liberar.aspx");

        }
    }
}