using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bebida : Insumo
    {

        
        public Decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public bool Copa { get; set; }
        public Marca marca { get; set; }
        public bool Estado { get; set; }


    }
}
