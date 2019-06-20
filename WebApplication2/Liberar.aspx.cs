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

    
    public partial class Liberar : System.Web.UI.Page
    {
        MesaNegocio negome = new MesaNegocio();
        List<Mesa> listamesas;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Label1.Text == "Seleccione una mesa")
            {
                btnLiberar.Visible = false;
            }
            else
            {
                btnLiberar.Visible = true;
            }


            ddlmesas.AutoGenerateSelectButton = true;
            cargarGrilla();
        }

        protected void cargarGrilla()
        {
            listamesas = negome.mesasXmesero(Convert.ToInt64((Int64)Session["id"]));

            ddlmesas.DataSource = listamesas;
            ddlmesas.DataBind();


        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLiberar.Visible = true;

            if (ddlmesas.SelectedRow.Cells[6].Text == "Libre")
            {
                btnLiberar.Text = "Ocupar";
            }
            else
            {
                btnLiberar.Text = "Liberar";
            }
            Label1.Text = "Mesa "+ ddlmesas.SelectedRow.Cells[2].Text;
        }

        protected void btnLiberar_Click(object sender, EventArgs e)
        {
            if (ddlmesas.SelectedRow != null) { 
                
                if (btnLiberar.Text=="Liberar")
                {
                    negome.LiberarMesa(Convert.ToInt64(ddlmesas.SelectedRow.Cells[2].Text), false);
                    btnLiberar.Text = "Ocupar";
                }
                else if (btnLiberar.Text == "Ocupar")
                {
                    negome.LiberarMesa(Convert.ToInt64(ddlmesas.SelectedRow.Cells[2].Text), true);
                    btnLiberar.Text = "Liberar";
                }


                cargarGrilla();
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Principal.aspx");
        }

        protected void ddlmesas_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;


        }
    }
}