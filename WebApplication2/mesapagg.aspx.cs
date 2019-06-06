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
           
                listalocalmesa = negome.mesasXmesero(Convert.ToInt64((string)Session["id"]));
                ddlMesa.DataSource = null;
                ddlMesa.DataSource = listalocalmesa;
                ddlMesa.DataTextField = "IdMesa";
               ddlMesa.DataValueField = "IdMesa";
                ddlMesa.DataBind();
            
            Label1.Text = Session["id"].ToString();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}