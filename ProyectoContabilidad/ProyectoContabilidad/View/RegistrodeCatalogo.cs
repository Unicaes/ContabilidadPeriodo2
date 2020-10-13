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
    public partial class RegistrodeCatalogo : Form
    {
        private List<Catalogo> itemsCatalogo;
        private FileStream fs;
        private BinaryFormatter bf;
        private int fila;
        public RegistrodeCatalogo()
        {
            InitializeComponent();
            itemsCatalogo = new List<Catalogo>();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            fs = new FileStream("catalogo.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf = new BinaryFormatter();
            try
            {
                itemsCatalogo = (List<Catalogo>)bf.Deserialize(fs);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                //si falla es porque esta vacio el bin
            }
            poblarTabla(itemsCatalogo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo oCatalogo = new Catalogo();
            int codigo;
            if (int.TryParse(this.textBox1.Text, out codigo))
            {
                oCatalogo.codigo = codigo;
            }
            else
            {
                MessageBox.Show("Error, el codigo ingresado es invalido");
                return;
            }
            oCatalogo.descripcion = this.textBox2.Text;
            itemsCatalogo.Add(oCatalogo);
            poblarTabla(itemsCatalogo);
            SerializarTabla();
        }

        private void SerializarTabla()
        {
            bf.Serialize(fs, itemsCatalogo);
        }

        void poblarTabla(List<Catalogo> items)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            for (int i = 0; i < items.Count; i++)
            {
                object[] o = { items[i].codigo, items[i].descripcion };
                this.dataGridView1.Rows.Add(o);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = this.dataGridView1.CurrentCell.RowIndex;
            this.textBox1.Text = itemsCatalogo[fila].codigo.ToString();
            this.textBox2.Text = itemsCatalogo[fila].descripcion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Catalogo oCatalogo = new Catalogo();
            int codigo;
            if (int.TryParse(this.textBox1.Text, out codigo))
            {
                oCatalogo.codigo = codigo;
            }
            else
            {
                MessageBox.Show("Error, el codigo ingresado es invalido");
                return;
            }
            oCatalogo.descripcion = this.textBox2.Text;
            itemsCatalogo[fila] = oCatalogo;
            poblarTabla(itemsCatalogo);
            SerializarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalogo oC = itemsCatalogo[fila];
            DialogResult resp = MessageBox.Show("Esta seguro que desea eliminar el registro con codigo:" + oC.codigo + " y desripcion: " + oC.descripcion, "no se que va aqui", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                itemsCatalogo.RemoveAt(fila);
            }
            else
            {
                return;
            }
            poblarTabla(itemsCatalogo);
            SerializarTabla();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            fila = this.dataGridView1.CurrentCell.RowIndex;
            this.textBox1.Text = itemsCatalogo[fila].codigo.ToString();
            this.textBox2.Text = itemsCatalogo[fila].descripcion;
        }
    }
}
