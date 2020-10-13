using ProyectoContabilidad.Model;
using ProyectoContabilidad.Services;
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
            this.dataGridView1.Rows.Add(new object[] { 1, "a" });
            this.dataGridView1.Rows.Add(new object[] { 2, "b" });
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var fila = this.dataGridView1.CurrentCell.RowIndex;
            Singleton.Instance.codigo = Convert.ToInt32(this.dataGridView1.Rows[fila].Cells[0].Value);
            Singleton.Instance.descripcion = this.dataGridView1.Rows[fila].Cells[1].Value.ToString();
            this.Dispose();
        }
    }
}