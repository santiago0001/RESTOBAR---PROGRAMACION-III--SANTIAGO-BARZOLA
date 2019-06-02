using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Mesa
    {
        public Int64 IdMesero { get; set; }
        public Int64 IdMesa { get; set; }
        public string NomApe { get; set; }
        public Boolean ocupado { get; set; }
        public Boolean estado { get; set; }
        public string stOcupado { get; set; }


    }
}
