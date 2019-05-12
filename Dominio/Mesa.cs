using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Mesa
    {
        public Pedido Pedido { get; set; }
        public int Minutos { get; set; }
        public Mesero Mesero { get; set; }
        public Silla silla { get; set; }
    }
}
