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
    }
}
