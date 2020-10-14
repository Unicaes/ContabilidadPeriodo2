using ProyectoContabilidad.Model;
using ProyectoContabilidad.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidad.View
{
    public partial class Mayorizacion : Form
    {
        private List<Asiento> asientos;
        public Mayorizacion()
        {
            this.TopLevel = false;
            InitializeComponent();

            // Movimientos
            if (Singleton.Instance.Asientos!= null && Singleton.Instance.Asientos.Count>0)
            {
                asientos = Singleton.Instance.Asientos;
                for (int i = 0; i < Singleton.Instance.Asientos.Count; i++)
                {
                    this.dataGridView1.Rows.Add(new Object[] {
                        asientos[i].codigo, asientos[i].descripcion,
                        asientos[i].NumeroAsiento, asientos[i].Fecha.ToString("MM/dd/yyyy"),
                        "$ " + asientos[i].Debe,  "$ "+ asientos[i].Haber });
                }
            }

            // Resultados
            Resumen resumen;
            List<Resumen> lresumen = new List<Resumen>();
            ArrayList lcodigos = new ArrayList();

            for (int i = 0; i < asientos.Count; i++)
            {
                if (!(lcodigos.Contains(asientos[i].codigo)))
                {
                    lcodigos.Add(asientos[i].codigo);
                }
            }

            foreach (int cod_cuenta in lcodigos)
            {
                double haber = 0; double debe = 0; String cuenta = "";
                for (int i = 0; i < asientos.Count; i++)
                {
                    if (cod_cuenta == asientos[i].codigo)
                    {
                        haber += asientos[i].Haber;
                        debe += asientos[i].Debe;
                        cuenta = asientos[i].descripcion;
                    }                 
                }

                resumen = new Resumen();
                resumen.codigo = cod_cuenta;
                resumen.descripcion = cuenta;
                resumen.DebeTotal = debe;
                resumen.HaberTotal = haber;
                resumen.getResultantes();
                lresumen.Add(resumen);
            }
            
            for (int i = 0; i < lresumen.Count; i++)
            {
                this.dataGridView2.Rows.Add(new Object[] {
                    lresumen[i].codigo,
                    lresumen[i].descripcion,
                    "$ " + lresumen[i].DebeTotal,
                    "$ " + lresumen[i].HaberTotal,
                    "$ " + lresumen[i].DebeResultante,
                    "$ " + lresumen[i].HaberResultante});
            }
        }
    }
}
