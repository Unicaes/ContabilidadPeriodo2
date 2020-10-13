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
    public partial class LibroDiario : Form
    {
        public LibroDiario()
        {
            this.TopLevel = false;
            InitializeComponent();
            if (Singleton.Instance.Asientos != null)
            {
                this.txtAsiento.Text = Singleton.Instance.Asientos[Singleton.Instance.Asientos.Count - 1].NumeroAsiento + 1.ToString();
            }
            else
            {
                this.txtAsiento.Text = "1";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CatalogoDeCuentas frmCatalogoDeCuentas = new CatalogoDeCuentas(this);
            frmCatalogoDeCuentas.Show();
        }
        public void cargarDatos()
        {
            this.txtCodigo.Text = Singleton.Instance.codigo.ToString();
            this.txtConcepto.Text = Singleton.Instance.descripcion;
        }
        private void LibroDiario_Shown(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = this.dtpFecha.Value;
            if (Singleton.Instance.Asientos == null)
            {
                return;
            }
            var similar = from c in Singleton.Instance.Asientos
                          where c.Fecha.Equals(fecha)
                          select c;
            if (similar.Count() >= 0)
            {
                this.txtAsiento.Text = similar.First().NumeroAsiento.ToString();
            }
            else
            {
                this.txtAsiento.Text = Singleton.Instance.Asientos[Singleton.Instance.Asientos.Count - 1].NumeroAsiento + 1.ToString();
            }
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            try
            {
                Asiento asiento = new Asiento();
                List<Asiento> asientos = new List<Asiento>();
                if (txtAsiento.Text == "" || txtCodigo.Text == "" ||txtHaber.Text == ""|| txtHaber.Text == "")
                {

                    MessageBox.Show("Por favor ingrese los datos",
                       "debidamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                   /* if (Convert.ToInt32(txtAsiento.Text) == asiento.NumeroAsiento)
                    {

                    }*/
                    for (int i = 0; i < asientos.Count; i++)
                    {
                        if (Convert.ToInt32(txtCodigo.Text) == asiento.codigo && Convert.ToInt32(txtAsiento.Text) == asiento.NumeroAsiento)
                        {
                            MessageBox.Show("No es permitido repetir codigo de cuenta",
                            "En el mismo asiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            asiento.NumeroAsiento = Convert.ToInt32(txtAsiento.Text);
                            asiento.Fecha = dtpFecha.Value.Date;
                            asiento.codigo = Convert.ToInt32(txtCodigo.Text);
                            asiento.descripcion = txtConcepto.Text;
                            asiento.Haber = Convert.ToDouble(txtHaber.Text);
                            asiento.Debe = Convert.ToDouble(txtDebe.Text);


                            Singleton.Instance.Asientos.Add(asiento);
                            break;
                        }
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ah ocurrido un error", "Ah ocurrido un error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                throw;
            }
        }
    }
}
