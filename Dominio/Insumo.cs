using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {
        public int id { get; set; }
        
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public Decimal Precio { get; set; }
               
    }
}
