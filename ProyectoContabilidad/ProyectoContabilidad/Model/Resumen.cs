using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoContabilidad.Model
{
    class Resumen
    {
        public Catalogo cuenta { get; set; }
        public Double Debe { get; set; }
        public Double Haber { get; set; }
    }
}
