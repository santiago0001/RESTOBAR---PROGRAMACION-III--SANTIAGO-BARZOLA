using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace WebApplication2
{
    public partial class ExitoCobro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int columnsCount =(int) Session["cantidadColumnas"];



        }
    }
}