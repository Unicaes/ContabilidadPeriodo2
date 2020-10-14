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
    public partial class Balance : Form
    {
        private List<Resumen> resumenes;
        double suma1, suma2, suma3, suma4;
        public Balance()
        {
            this.TopLevel = false;
            InitializeComponent();
            suma1 = 0;
            suma2 = 0;
            suma3 = 0;
            suma4 = 0;
            resumenes = Singleton.Instance.Resumenes;
            for (int i = 0; i < resumenes.Count; i++)
            {
                this.dataGridView1.Rows.Add(new object[] { resumenes[i].codigo, resumenes[i].descripcion, resumenes[i].DebeTotal, resumenes[i].HaberTotal, resumenes[i].DebeResultante, resumenes[i].HaberResultante });
                suma1 += resumenes[i].DebeTotal;
                suma2 += resumenes[i].HaberTotal;
                suma3 += resumenes[i].DebeResultante;
                suma4 += resumenes[i].HaberResultante;
            }
            this.lblSuma1.Text = suma1.ToString();
            this.lblSuma2.Text = suma2.ToString();
            this.lblSuma3.Text = suma3.ToString();
            this.lblSuma4.Text = suma4.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
