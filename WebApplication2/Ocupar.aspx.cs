using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApplication2
{
    public partial class Ocupar : System.Web.UI.Page
    {
        MesaNegocio negome = new MesaNegocio();
        List<Mesa> listamesas;
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlmesas.AutoGenerateSelectButton = true;
            cargarGrilla();
        }
        protected void cargarGrilla()
        {
            listamesas = negome.mesasXmesero(Convert.ToInt64((string)Session["id"]));

            ddlmesas.DataSource = listamesas;
            ddlmesas.DataBind();


        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Mesa " + ddlmesas.SelectedRow.Cells[2].Text;

        }

        protected void btnLiberar_Click(object sender, EventArgs e)
        {
            if (ddlmesas.SelectedRow != null)
            {
                negome.LiberarMesa(Convert.ToInt64(ddlmesas.SelectedRow.Cells[2].Text), true);
                cargarGrilla();
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Principal.aspx");
        }
    }
}