using ProyectoContabilidad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidad.View
{
    public partial class CatalogoDeCuentas : Form
    {
        public CatalogoDeCuentas()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            poblarTabla();
        }

        private void poblarTabla()
        {
            this.dataGridView1.Rows.Add(new object[] { "codigo", "descripcion" });
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var fila = this.dataGridView1.CurrentCell.RowIndex;
            //aqui se pone el codigo pa mandarlo al otro form
        }
    }
}
