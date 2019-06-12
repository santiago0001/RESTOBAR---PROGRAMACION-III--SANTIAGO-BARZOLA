using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApplication2
{
    public partial class mesapagg : System.Web.UI.Page
    {
        MesaNegocio negome = new MesaNegocio();
        private List<Mesa> listalocalmesa;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                listalocalmesa = negome.mesasXmesero(Convert.ToInt64((string)Session["id"]));
                ddlMesa.DataSource = null;
                ddlMesa.DataSource = listalocalmesa;
                ddlMesa.DataTextField = "IdMesa";
                ddlMesa.DataValueField = "IdMesa";
                ddlMesa.DataBind();
                droplist();
            }
            
        }
        protected void droplist()
        {
            if (ddlMesa.SelectedItem != null) { 
            Label1.Text = ddlMesa.SelectedItem.ToString();
            Session["idMesa"] = ddlMesa.SelectedItem.Value.ToString();
            } 
            else
            {
                Label1.Text = "No tiene mesas asignadas";
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            droplist();
            Response.Redirect("Pedidos.aspx");
        }

        protected void butAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("principal.aspx");

        }
    }
}