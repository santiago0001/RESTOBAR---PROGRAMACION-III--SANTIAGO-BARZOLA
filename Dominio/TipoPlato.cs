using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class TipoPlato
    {
        public Int64 id { get; set; }
        public string nombre { get; set; }

        public Boolean estado { get; set; }


        public override string ToString()
        {
            return nombre;
        }
    }
}
