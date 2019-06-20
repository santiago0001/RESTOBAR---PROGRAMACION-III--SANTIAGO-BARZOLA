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

        public string Plato  { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Int64 Cantidad { get; set; }
        public string Estado { get; set; }




    }
}
