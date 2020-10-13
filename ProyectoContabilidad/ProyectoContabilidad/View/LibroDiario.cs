﻿using ProyectoContabilidad.Model;
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
        Asiento asiento = new Asiento();
        List<Asiento> asientos = new List<Asiento>();
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
            cargarDatosTabla();
        }

        private void cargarDatosTabla()
        {
            if (Singleton.Instance.Asientos != null && Singleton.Instance.Asientos.Count > 0)
            {
                List<Asiento> asientos = Singleton.Instance.Asientos;
                for (int i = 0; i < Singleton.Instance.Asientos.Count; i++)
                {
                    this.dataGridView1.Rows.Add(new Object[] { asientos[i].NumeroAsiento, asientos[i].Fecha, asientos[i].codigo, asientos[i].descripcion, asientos[i].Debe, asientos[i].Haber });
                }
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
            try
            {
                this.txtAsiento.Text = similar.First().NumeroAsiento.ToString();
            }
            catch (Exception)
            {
                this.txtAsiento.Text = (Convert.ToInt32(Singleton.Instance.Asientos[Singleton.Instance.Asientos.Count - 1].NumeroAsiento) + 1).ToString();
            }
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            try
            {
                asiento = new Asiento();

                if (txtAsiento.Text == "" || txtCodigo.Text == "" || txtHaber.Text == "" || txtHaber.Text == "")
                {

                    MessageBox.Show("Por favor ingrese los datos",
                       "debidamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    for (int i = 0; i < asientos.Count; i++)
                    {
                        if (Convert.ToInt32(txtCodigo.Text) == asiento.codigo && Convert.ToInt32(txtAsiento.Text) == asiento.NumeroAsiento)
                        {
                            MessageBox.Show("No es permitido repetir codigo de cuenta",
                            "En el mismo asiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    asiento.NumeroAsiento = Convert.ToInt32(txtAsiento.Text);
                    asiento.Fecha = dtpFecha.Value.Date;
                    asiento.codigo = Convert.ToInt32(txtCodigo.Text);
                    asiento.descripcion = txtConcepto.Text;
                    asiento.Haber = Convert.ToDouble(txtHaber.Text);
                    asiento.Debe = Convert.ToDouble(txtDebe.Text);

                    asientos.Add(asiento);
                    this.dataGridView1.Rows.Clear();
                    this.dataGridView1.Refresh();
                    for (int i = 0; i < asientos.Count; i++)
                    {
                        this.dataGridView1.Rows.Add(new Object[] {asientos[i].NumeroAsiento,asientos[i].Fecha,asientos[i].codigo,asientos[i].descripcion,asientos[i].Debe,asientos[i].Haber});
                    }
                    Singleton.Instance.Asientos = asientos;
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
