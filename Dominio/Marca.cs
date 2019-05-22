using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Marca
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public Boolean Estado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
