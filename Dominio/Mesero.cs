using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Mesero : Empleado
    {
        public int mesa { get; set; }
        public int CantReclamos { get; set; }

    }
}
