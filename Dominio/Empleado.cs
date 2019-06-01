using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public Int64 Id { get; set; }

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Puesto { get; set; }
        public int Dni { get; set; }
        public Boolean Estado { get; set; }
        public String Usuario { get; set; }
        public String Contraseña { get; set; }


    }
}
