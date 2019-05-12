using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Reclamo
    {
        public DateTime Fecha { get; set; }
        public Mesero mesero { get; set; }
        public String Nota { get; set; }
    }
}
