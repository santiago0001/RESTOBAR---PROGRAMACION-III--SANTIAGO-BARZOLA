using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bebida : Insumo
    {
        public String Marca { get; set; }
        public decimal Litros { get; set; }
        public bool Vaso { get; set; }
        public bool Copa { get; set; }
                     
    }
}
