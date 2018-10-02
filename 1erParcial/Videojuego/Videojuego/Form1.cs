using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videojuego
{
    public partial class Form1 : Form
    {
        public List<Videojuego> lv;
        public Form1()
        {
            InitializeComponent();
            lv = new List<Videojuego>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaRegistro vr = new VentanaRegistro(lv);
            vr.ShowDialog();
            actualiza();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            lv.RemoveAt(i);
            listBox1.Items.RemoveAt(i);
        }
        private void actualiza()
        {
            listBox1.Items.Clear();
            foreach(Videojuego v in lv)
            {
                listBox1.Items.Add(v.datos());
            }
        }
    }
}
