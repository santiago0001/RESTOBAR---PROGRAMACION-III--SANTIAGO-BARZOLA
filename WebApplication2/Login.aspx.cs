using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        EmpleadosNegocio negoem = new EmpleadosNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["id"] = negoem.Login(txtus.Text, txtcon.Text);
            if ((Int64)Session["id"]>0)
            {
                Session["nomMesero"] = negoem.NombreEmpleado((Int64)Session["id"]);
                Response.Redirect("~/Principal.aspx");
            }
            else
            {
                lbErro.Text = "USUARIO Y/O CONTRASEÑA INCORRECTOS";
            }

        }
    }
}