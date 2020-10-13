using ProyectoContabilidad.Model;
using ProyectoContabilidad.Services;
using System;
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
        }
    }
}
