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
    public partial class RegistroEmpresa : Form
    {
        public RegistroEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtAsiento.Text) || String.IsNullOrWhiteSpace(this.textBox2.Text)|| String.IsNullOrWhiteSpace(this.textBox3.Text))
            {
                return;
            }
            Singleton.Instance.Empresa = new Empresa
            {
                Inicio = this.dateTimePicker1.Value,
                Nombre = this.txtAsiento.Text,
                Ocupacion = this.textBox2.Text,
                Representante = this.textBox3.Text
            };
            MainForm frmMain = new MainForm();
            frmMain.Show();
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
