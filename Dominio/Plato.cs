using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Plato : Insumo
    {  
        public bool Tenedor { get; set; }
        public bool Cuchillo { get; set; }
        public bool Cuchara { get; set; }
        
    }
}
