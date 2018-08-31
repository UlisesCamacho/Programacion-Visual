using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExamen
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
            VentanaRegistro r = new VentanaRegistro();
            r.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            lv.RemoveAt(i);
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
