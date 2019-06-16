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
    
    public partial class WebForm3 : System.Web.UI.Page
    {
        MesaNegocio negome = new MesaNegocio();
        List<Mesa> MesaLocal;

        PedidoNegocio negope = new PedidoNegocio();
        List<PedidoPlato> listaPendientesPla;
        List<PedidoBebida> listaBebidasPend;
        protected void Page_Load(object sender, EventArgs e)
        {
            gbPlatos.AutoGenerateSelectButton = true;
            gvBebidas.AutoGenerateSelectButton = true;


            if (IsPostBack == false)
            {
                Cargarddlmesas();
                
            }
            PlatosPendientes();
            BebidasPendientes();
            labMesa.Text = "Mesa " + ddlMesas.SelectedItem.Value;
        }

        protected void Cargarddlmesas()
        {
            MesaLocal = negome.mesasXmesero(Convert.ToInt64((string)Session["id"]));
            ddlMesas.DataSource = null;
            ddlMesas.DataSource = MesaLocal;
            ddlMesas.DataTextField = "IdMesa";
            ddlMesas.DataValueField = "IdMesa";
            ddlMesas.DataBind();
        }

        protected void PlatosPendientes()
        {
            listaPendientesPla = negope.ListarPlatoPendiente(Convert.ToInt64(ddlMesas.SelectedItem.Value));
            gbPlatos.DataSource = null;
            gbPlatos.DataSource = listaPendientesPla;
            gbPlatos.DataBind();
        }

        protected void BebidasPendientes()
        {
            listaBebidasPend = negope.ListarBebidasPendiente(Convert.ToInt64(ddlMesas.SelectedItem.Value));
            gvBebidas.DataSource = null;
            gvBebidas.DataSource = listaBebidasPend;
            gvBebidas.DataBind();
        }

        protected void gdvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            labPedpla.Text = "Pedido N° " + gbPlatos.SelectedRow.Cells[1].Text 
                + ",  "+ gbPlatos.SelectedRow.Cells[2].Text;
        }

        protected void gdvPedidoBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            labBeb.Text = "Pedido N° " + gvBebidas.SelectedRow.Cells[1].Text
                + ",  " + gvBebidas.SelectedRow.Cells[2].Text;
        }
    }
}