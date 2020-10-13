﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoContabilidad.Model
{
    class Asiento
    {
        public int NumeroAsiento { get; set; }
        public DateTime Fecha { get; set; }
        public Catalogo Catalogo { get; set; }
        public Double Debe { get; set; }
        public Double Haber { get; set; }
    }
}
