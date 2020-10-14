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
    public partial class MainForm : Form
    {
        private Balance frmBalance;
        private LibroDiario frmLibroDiario;
        private Mayorizacion frmMayorizacion;
        private AcercaDe frmAcercaDe;
        public MainForm()
        {
            InitializeComponent();
            this.Text = Singleton.Instance.Empresa.Nombre;
            frmLibroDiario = new LibroDiario(this);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmLibroDiario);
            frmLibroDiario.Show();
            this.btnMayorizacion.Enabled = false;
            this.btnBalance.Enabled = false;
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            frmLibroDiario = new LibroDiario(this);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmLibroDiario);
            frmLibroDiario.Show();
        }

        private void btnMayorizacion_Click(object sender, EventArgs e)
        {
            frmMayorizacion = new Mayorizacion();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmMayorizacion);
            frmMayorizacion.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            frmBalance = new Balance();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmBalance);
            frmBalance.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDe = new AcercaDe();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmAcercaDe);
            frmAcercaDe.Show();
        }
        public void habilitarBotones()
        {
            this.btnMayorizacion.Enabled = true;
            this.btnBalance.Enabled = true;
        }
    }
}
