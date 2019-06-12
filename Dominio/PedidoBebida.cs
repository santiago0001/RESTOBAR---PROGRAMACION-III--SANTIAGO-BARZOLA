using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class PedidoBebida
    {
        public Int64 Id { get; set; }

        public string Nom { get; set; }
        public string Descr { get; set; }
        public decimal precio { get; set; }
        public Int64 Cant { get; set; }

        public string Entregado { get; set; }
    }
}
