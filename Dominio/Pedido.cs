using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Pedido
    {
        public Bebida Bebida { get; set; }
        public Plato  Plato { get; set; }
        public Decimal Total { get; set; }
    }
}
