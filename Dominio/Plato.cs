﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Plato : Insumo
    {
        public Decimal Precio { get; set; }
        public string Descripcion { get; set; }
       
        public TipoPlato Tipo { get; set; }

    }
}
