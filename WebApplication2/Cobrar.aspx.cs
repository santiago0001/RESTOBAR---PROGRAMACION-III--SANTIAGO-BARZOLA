using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;


namespace WebApplication2
{
    public partial class Cobrar : System.Web.UI.Page
    {
        List<Mesa> mesasLocal;
        MesaNegocio negome = new MesaNegocio();

        List<PedidoPlato> platoLocal;
        PedidoNegocio negocio = new PedidoNegocio();

        List<PedidoBebida> BebidaLocal;
        decimal total;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
              //  LabelExito.Text = "sss ";
                droplist();
            }
            if (ddlmesa.SelectedItem != null)
            {

                PlatosCobrar();
                BebidasCobrar();
                CobrarTotal();
                LabTotal.Text = " $" + Convert.ToString(total);
            }
                            

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void droplist()
        {


            mesasLocal = negome.mesasXmesero(Convert.ToInt64((Int64)Session["id"]));
            ddlmesa.DataSource = null;
            ddlmesa.DataSource = mesasLocal;
            ddlmesa.DataTextField = "mesa";
            ddlmesa.DataValueField = "mesa";
            ddlmesa.DataBind();

        }

        protected void PlatosCobrar()
        {
            platoLocal = negocio.CobrarPlatos(Convert.ToInt64(ddlmesa.SelectedItem.Value));
            GVplatos.DataSource = null;
            GVplatos.DataSource = platoLocal;
            GVplatos.DataBind();
        }

        protected void BebidasCobrar()
        {
            BebidaLocal = negocio.CobrarBebidas(Convert.ToInt64(ddlmesa.SelectedItem.Value));
            GVbebidas.DataSource = null;
            GVbebidas.DataSource = BebidaLocal;
            GVbebidas.DataBind();
        }

        protected void CobrarTotal()
        {
            if (platoLocal.Count > 0)
            {
                for (int i = 0; i < platoLocal.Count; i++)
                {
                    total = total + (platoLocal[i].Precio * platoLocal[i].Cantidad);
                }

            }
            if (BebidaLocal.Count > 0)
            {
                for (int i = 0; i < BebidaLocal.Count; i++)
                {
                    total = total + (BebidaLocal[i].Precio * BebidaLocal[i].Cantiadad);
                }
            }

        }

        protected void GVplatos_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[5].Visible = false;

        }

        protected void GVbebidas_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[5].Visible = false;

        }

        protected void Button5_Click(object sender, EventArgs e)
        { if (GVbebidas.HeaderRow== null&& GVplatos.HeaderRow == null)
            {

            }
        else {
                negome.LiberarMesa(Convert.ToInt64(ddlmesa.SelectedItem.Value), false);
                negocio.CobrarPedidos(Convert.ToInt64 (ddlmesa.SelectedItem.Value));
            int columnsCount = GVplatos.HeaderRow.Cells.Count;
            // Create the PDF Table specifying the number of columns
            PdfPTable pdfTable = new PdfPTable(columnsCount);
                pdfTable.AddCell("       Total= " );
                pdfTable.AddCell("$" + total);
                pdfTable.AddCell("       ");
                pdfTable.AddCell("       ");
                pdfTable.AddCell("       ");
                pdfTable.AddCell("       ");
                Session["cantidadColumnas"] = columnsCount;
                if (GVplatos.HeaderRow != null) {
                // Loop thru each cell in GrdiView header row
                foreach (TableCell gridViewHeaderCell in GVplatos.HeaderRow.Cells)
            {
                // Create the Font Object for PDF document
                Font font = new Font();
                // Set the font color to GridView header row font color
                font.Color = new BaseColor(GVplatos.HeaderStyle.ForeColor);

                // Create the PDF cell, specifying the text and font
                PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                // Set the PDF cell backgroundcolor to GridView header row BackgroundColor color
                pdfCell.BackgroundColor = new BaseColor(GVplatos.HeaderStyle.BackColor);

                // Add the cell to PDF table
                pdfTable.AddCell(pdfCell);
            }

            // Loop thru each datarow in GrdiView
            foreach (GridViewRow gridViewRow in GVplatos.Rows)
            {
                if (gridViewRow.RowType == DataControlRowType.DataRow)
                {
                    // Loop thru each cell in GrdiView data row
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(GVplatos.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(GVplatos.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell);
                    }
                }
                }
            }
            if (GVbebidas.HeaderRow !=null) { 
            foreach (TableCell gridViewHeaderCell in GVbebidas.HeaderRow.Cells)
            {
                // Create the Font Object for PDF document
                Font font = new Font();
                // Set the font color to GridView header row font color
                font.Color = new BaseColor(GVbebidas.HeaderStyle.ForeColor);

                // Create the PDF cell, specifying the text and font
                PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                // Set the PDF cell backgroundcolor to GridView header row BackgroundColor color
                pdfCell.BackgroundColor = new BaseColor(GVbebidas.HeaderStyle.BackColor);

                    // Add the cell to PDF table
                
                pdfTable.AddCell(pdfCell);
            }
            
            // Loop thru each datarow in GrdiView
            foreach (GridViewRow gridViewRow in GVbebidas.Rows)
            {
                if (gridViewRow.RowType == DataControlRowType.DataRow)
                {
                    // Loop thru each cell in GrdiView data row
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(GVbebidas.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(GVbebidas.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell);
                    }
                }
            }
            }
            pdfTable.AddCell("Total= $"+total);


            // Create the PDF document specifying page size and margins
            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            // Roate page using Rotate() function, if you want in Landscape
            // pdfDocument.SetPageSize(PageSize.A4.Rotate());

            // Using PageSize.A4_LANDSCAPE may not work as expected
            // Document pdfDocument = new Document(PageSize.A4_LANDSCAPE, 10f, 10f, 10f, 10f);

            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

                LabelExito.Text = "COBRADO CON EXITO, se te descargo en PDF el detalle ";
                PlatosCobrar();
                BebidasCobrar();
            pdfDocument.Open();
            pdfDocument.Add(pdfTable);
            pdfDocument.Close();
                Response.ContentType = "application/pdf";
                Response.AppendHeader("content-disposition",
                    "attachment;filename=Employees.pdf");
                Response.Write(pdfTable);
                Response.Flush();
                Response.End();

            }
        }

        protected void GVplatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GVbebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}