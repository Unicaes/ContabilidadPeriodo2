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
        private List<Catalogo> itemsCatalogo;
        private FileStream fs;
        private BinaryFormatter bf;
        public CatalogoDeCuentas()
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
            poblarTabla();
        }

        private void poblarTabla()
        {
            for (int i = 0; i < itemsCatalogo.Count; i++)
            {
                object[] o = { itemsCatalogo[i].codigo, itemsCatalogo[i].descripcion };
                this.dataGridView1.Rows.Add(o);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            var fila = this.dataGridView1.CurrentCell.RowIndex;
            //aqui se pone el codigo pa mandarlo al otro form
        }
    }
}
