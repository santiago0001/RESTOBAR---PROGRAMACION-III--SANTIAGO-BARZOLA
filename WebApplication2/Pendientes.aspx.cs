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
            if (ddlMesas.SelectedItem != null) { 
            PlatosPendientes();
            BebidasPendientes();
            labMesa.Text = "Mesa " + ddlMesas.SelectedItem.Value;
            }
        }

        protected void Cargarddlmesas()
        {
            MesaLocal = negome.mesasXmesero(Convert.ToInt64((Int64)Session["id"]));
            ddlMesas.DataSource = null;
            ddlMesas.DataSource = MesaLocal;
            ddlMesas.DataTextField = "mesa";
            ddlMesas.DataValueField = "mesa";
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            if ( listaPendientesPla.Count>0)
            {
                negope.Entregado(Convert.ToInt64(gbPlatos.SelectedRow.Cells[1].Text));
                PlatosPendientes();
                labPedpla.Text = " ";
            }
                

        }

        protected void Button6_Click(object sender, EventArgs e)
        { if ( listaBebidasPend.Count > 0) {
                negope.Entregado(Convert.ToInt64(gvBebidas.SelectedRow.Cells[1].Text));
                BebidasPendientes();
                labBeb.Text =  "    ";
            }
            
        }

        protected void gbPlatos_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Width = 200;

        }

        protected void gvBebidas_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;

        }

        protected void gbPlatos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }
    }
}