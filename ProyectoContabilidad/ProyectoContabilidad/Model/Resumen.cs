using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoContabilidad.Model
{
    class Resumen
    {
        public int codigo { get; set; }
        public String descripcion { get; set; }
        public Double Debe { get; set; }
        public Double Haber { get; set; }
    }
}
