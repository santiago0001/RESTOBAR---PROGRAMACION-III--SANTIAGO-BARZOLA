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


                droplist();
            }
            labCant.Text = negocioEm.cantidaMesas((Int64)Session["id"]).ToString();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
     

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        protected void droplist()
        {
            LabNombre.Text = (string)Session["nomMesero"];
          

        }
        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {

            droplist();

        }
    }
}