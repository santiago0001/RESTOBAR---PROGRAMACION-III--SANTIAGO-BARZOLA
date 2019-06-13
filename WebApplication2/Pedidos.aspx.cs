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
    public partial class WebForm2 : System.Web.UI.Page
    {
        TipoPlatoNegocio negotipo = new TipoPlatoNegocio();
        private List<TipoPlato> listaTipo;

        PlatoNegocio negoPlato = new PlatoNegocio();
        private List<Plato> listaPlato;
        Plato platoLocal;

        PedidoNegocio negoPe = new PedidoNegocio();
        private List<PedidoPlato> listaPedido;

        private List<PedidoBebida> listaPedidoBebida;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                listaTipo = negotipo.listarTipoPlato();
                ddltipo.DataSource = null;
                ddltipo.DataSource = listaTipo;
                ddltipo.DataTextField = "nombre" ;
                ddltipo.DataValueField = "id";
                ddltipo.DataBind();

                CagarddlPlatos();

                droplist();
                cargarGrilla();
                cargarPrecio();

            }
            if (Session["idMesa"] != null) {
            LabelMesero.Text = Session["idMesa"].ToString();
            Session["idtipo"] = ddltipo.SelectedItem.Value;
            cargarGrilla();
            }

        }
        protected void droplist()
        {
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CagarddlPlatos()
        {
            listaPlato = negoPlato.listarPlatosXtipo(Convert.ToInt64(ddltipo.SelectedItem.Value));
            ddlPlato.DataSource = null;
            ddlPlato.DataSource = listaPlato;
            ddlPlato.DataTextField = "nombre";
            ddlPlato.DataValueField = "id";
            ddlPlato.DataBind();
            //cargarPrecio();

        }
        protected void ddltipo_TextChanged(object sender, EventArgs e)
        {
            CagarddlPlatos();

        }
        protected void cargarPrecio()
        {
            
                if (ddlPlato.SelectedItem.Value == null)
            {
                labPrecio.Text = "  ";
            }
            else
            {
                labPrecio.Text = negoPlato.precioPlato(Convert.ToInt64(ddlPlato.SelectedItem.Value)).ToString();
            }
        }
        protected void butAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("mesapagg.aspx");

        }

        protected void butCarga_Click(object sender, EventArgs e)
        {
            cargarGrilla();

        }

        protected void cargarGrilla ()
        {
            listaPedido = negoPe.ListarPlatosXmesa(Convert.ToInt64(Session["idMesa"].ToString()));

            gdvPedido.DataSource = listaPedido;
            gdvPedido.DataBind();

            listaPedidoBebida = negoPe.ListarBebidasPedido(Convert.ToInt64(Session["idMesa"].ToString()));

            gvBebidas.DataSource = listaPedidoBebida;
            gvBebidas.DataBind();


        }
        protected void gdvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPlato_TextChanged(object sender, EventArgs e)
        {
            cargarPrecio();
        }
    }
}