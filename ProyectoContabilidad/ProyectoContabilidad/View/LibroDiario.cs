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
    public partial class LibroDiario : Form
    {
        public LibroDiario()
        {
            this.TopLevel = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoDeCuentas frmCatalogoDeCuentas = new CatalogoDeCuentas();
            frmCatalogoDeCuentas.Show();
        }

        private void LibroDiario_Shown(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Singleton.Instance.codigo.ToString();
            this.txtConcepto.Text = Singleton.Instance.descripcion;
        }
    }
}
