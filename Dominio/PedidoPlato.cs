using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class PedidoPlato
    {


        public Int64 Id { get; set; }

        public string NomPlato  { get; set; }
        public string DescripPla { get; set; }
        public decimal precioPla { get; set; }
        public Int64 CantPla { get; set; }

        public string Entregado { get; set; }




    }
}
