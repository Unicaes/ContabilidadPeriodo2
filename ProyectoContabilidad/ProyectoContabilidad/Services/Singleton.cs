using ProyectoContabilidad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoContabilidad.Services
{
    class Singleton
    {
        private static Singleton current;
        public static Singleton Instance
        {
            get
            {
                if (current==null)
                {
                    current = new Singleton();
                }
                return current;
            }
        }
        public int codigo;
        public String descripcion;
        public Empresa Empresa { get; set; }
        public List<Asiento> Asientos { get; set; }
    }
}
