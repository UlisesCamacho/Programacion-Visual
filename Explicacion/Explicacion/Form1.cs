using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explicacion
{
    public partial class Form1 : Form
    {
        List<Videojuego> lv;
        public Form1()
        {
            InitializeComponent();
            lv = new List<Videojuego>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventantavj v = new Ventantavj(lv);
            v.ShowDialog();
            Actualiza();
        }

        private void Actualiza()
        {
            listBox1.Items.Clear();
            foreach (Videojuego v in lv)
            {
                listBox1.Items.Add(v.dameDatos());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            lv.RemoveAt(i);
            listBox1.Items.RemoveAt(i);
        }
    }
}
