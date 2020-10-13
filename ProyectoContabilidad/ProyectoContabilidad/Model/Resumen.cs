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
        public Double DebeTotal { get; set; }
        public Double HaberTotal { get; set; }
        public Double DebeResultante { get; set; }
        public Double HaberResultante{ get; set; }

        public void getResultantes()
        {
            double rest_debe = this.DebeTotal - this.HaberTotal;
            double rest_haber = this.HaberTotal - this.DebeTotal;

            // Termina en debe
            if (rest_debe > rest_haber)
            {
                this.DebeResultante = rest_debe;
                this.HaberResultante = 0;
            }

            // Termina en haber
            else if (rest_haber > rest_debe)
            {
                this.HaberResultante = rest_haber;
                this.DebeResultante = 0;
            }

            // Se cancelan
            else if (rest_debe == rest_haber)
            {
                this.DebeResultante = 0;
                this.HaberResultante = 0;
            }
        }
    }
}
