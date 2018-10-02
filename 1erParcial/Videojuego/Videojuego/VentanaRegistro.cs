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
    public partial class VentanaRegistro : Form
    {
        public List<Videojuego> lv;
        public VentanaRegistro(List<Videojuego> lv)
        {
            InitializeComponent();
            this.lv = lv;
            actualiza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Videojuego v = new Videojuego();
            v.nombre = textBox1.Text;
            v.año =Convert.ToInt32(textBox2.Text);
            lv.Add(v);
            listBox1.Items.Add(v.datos());
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i>-1)
            {
                textBox1.Text = lv[i].nombre;
                textBox2.Text = lv[i].año.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            lv[i].nombre = textBox1.Text;
            lv[i].año = Convert.ToInt32(textBox2.Text);
            listBox1.Items[i] = lv[i].datos();
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
