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

        BebidasNegocio negoBebida = new BebidasNegocio();
        MarcaNegocio negoMarca = new MarcaNegocio();

        private List<Bebida> listaBebida;
        private List<Marca> listaMarca;


        PlatoNegocio negoPlato = new PlatoNegocio();
        private List<Plato> listaPlato;
        Plato platoLocal;


        PedidoNegocio negoPe = new PedidoNegocio();
        private List<PedidoPlato> listaPedido;

        MesaNegocio negome = new MesaNegocio();
        List<Mesa> listamesa;

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

                CargaMarcasBeb();
                CargaBebida();
                CargarDescripcion();
                droplist();
            }
            if (Session["idMesa"] != null && ddlMesa.SelectedItem!=null) {
            LabelMesero.Text = ddlMesa.SelectedItem.Value;
            Session["idtipo"] = ddltipo.SelectedItem.Value;
            }
            //if ((bool) Session["stock"])
            //{
            //    CargaBebida();
            //    Session["stock"] = false;
            //}
            mesas();
            cargarGrilla();
        }
        protected void mesas()
        {
            if (ddlMesa.SelectedItem != null)
            {
                LabelMesero.Text = ddlMesa.SelectedItem.ToString();
                Session["idMesa"] = ddlMesa.SelectedItem.Value.ToString();
            }
            else
            {
                Label3.Text = " ";
                Label1.Text = " ";
                LabelMesero.Text = "No tiene mesas asignadas";
                btncargaBeb.Visible = false;
                butCarga.Visible = false;
            }
        }
        protected void droplist()
        {

            LabErrorBe.Text = "*";
            listamesa = negome.mesasXmesero(Convert.ToInt64((Int64)Session["id"]));
                ddlMesa.DataSource = null;
                ddlMesa.DataSource = listamesa;
                ddlMesa.DataTextField = "mesa";
                ddlMesa.DataValueField = "mesa";
                ddlMesa.DataBind();
               
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDescripcion();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaBebida();
            CargarDescripcion();
        }

        protected void CargaMarcasBeb()
        {
            LabErrorBe.Text = "*";
            listaMarca = negoMarca.listarMarcas();
            ddlMarcas.DataSource = null;
            ddlMarcas.DataSource = listaMarca;
            ddlMarcas.DataTextField = "nombre";
            ddlMarcas.DataValueField = "id";
            ddlMarcas.DataBind();

        }
        protected void CargaBebida()
        {
            LabErrorBe.Text = "*";
            listaBebida = negoBebida.listarBebidasXmarca(Convert.ToInt64(ddlMarcas.SelectedItem.Value));
            ddlbebida.DataSource = null;
            ddlbebida.DataSource = listaBebida;
            ddlbebida.DataTextField = "nombre";
            ddlbebida.DataValueField = "id";
            ddlbebida.DataBind();

        }

        protected void CagarddlPlatos()
        {
            LabErrorBe.Text = "*";
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
            cargarPrecio();

        }
        protected void cargarPrecio()
        {
            
                if (ddlPlato.SelectedItem == null)
            {
                labPrecio.Text = "  ";
            }
            else
            {
                string cadena = negoPlato.precioPlato(Convert.ToInt64(ddlPlato.SelectedItem.Value)).ToString(); ;

                string[] separadas;

                separadas = cadena.Split(',');
                labPrecio.Text = separadas[0];
            }
        }
        protected void butAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("mesapagg.aspx");

        }

        protected void butCarga_Click(object sender, EventArgs e)
        {
            int val = 0;
            int cant = 0;
            cant = negoPlato.CantidadPlatos(Convert.ToInt64(ddlPlato.SelectedItem.Value));
            if (int.TryParse(txtCant.Text, out val))
            {
                if (cant >= Convert.ToInt32(txtCant.Text))
                {
                    LabErrorPla.Text = "*";
                    cargarGrilla();
                    negoPe.AgregarPedidoPla(Convert.ToInt64(ddlPlato.SelectedItem.Value),
                        Convert.ToInt64(Session["idMesa"]), Convert.ToInt64(txtCant.Text),
                        Convert.ToInt64(Session["id"]), Convert.ToDecimal(labPrecio.Text));
                    cargarGrilla();
                    CagarddlPlatos();
                }
                else
                {
                    LabErrorPla.Text = "Solo quedan " + cant + " de " + ddlPlato.SelectedItem.Text;
                }
            }
               else
            {
                LabErrorPla.Text = "Debe ingresar numeros";
            }


            negome.LiberarMesa(Convert.ToInt64(Session["idMesa"]),true);     

        }

        protected void cargarGrilla ()
        {
            if (Session["idMesa"] != null)
            {
                listaPedido = negoPe.ListarPlatosXmesa(Convert.ToInt64(Session["idMesa"].ToString()));

                gdvPedido.DataSource = listaPedido;
                gdvPedido.DataBind();

                listaPedidoBebida = negoPe.ListarBebidasPedido(Convert.ToInt64(Session["idMesa"].ToString()));

                gvBebidas.DataSource = listaPedidoBebida;
                gvBebidas.DataBind();
            }

        }
        protected void gdvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPlato_TextChanged(object sender, EventArgs e)
        {
            cargarPrecio();
        }

        protected void butCargabeb_Click(object sender, EventArgs e)
        {
            int val = 0;

            if (int.TryParse(txtcantbeb.Text, out val))
            {
                int cant = 0;
                cant = negoBebida.CantidadBebidas(Convert.ToInt64(ddlbebida.SelectedItem.Value));
                if (cant >= Convert.ToInt32(txtcantbeb.Text))
                {
                    LabErrorBe.Text = "*";
                    cargarGrilla();
                    negoPe.AgregarBebidaPla(Convert.ToInt64(ddlbebida.SelectedItem.Value),
                        Convert.ToInt64(Session["idMesa"]), Convert.ToInt64(txtcantbeb.Text),
                         Convert.ToInt64(Session["id"])
                    );
                    cargarGrilla();
                    CargaBebida();
                }
                else
                {
                    LabErrorBe.Text = "Solo quedan " + cant + " de "+ ddlbebida.SelectedItem.Text;
                }
            }
            else
            {
                LabErrorBe.Text = "Debe ingresar numeros";
            }
            negome.LiberarMesa(Convert.ToInt64(Session["idMesa"]), true);

        }
        protected void CargarDescripcion()
        {
            if (ddlPlato.SelectedItem == null)
            {
                labPrecio.Text = "  ";
            }
            else
            {
                DescBeb.Text = negoBebida.DescripcionBebida(Convert.ToInt64(ddlbebida.SelectedItem.Value));

            }
        }
        protected void ddlbebida_TextChanged(object sender, EventArgs e)
        {
        }

        protected void txtcantbeb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}