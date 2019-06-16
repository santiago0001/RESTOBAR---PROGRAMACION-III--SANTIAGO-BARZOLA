using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class algo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Principal.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mesapagg.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Liberar.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pendientes.aspx");
        }
    }
}