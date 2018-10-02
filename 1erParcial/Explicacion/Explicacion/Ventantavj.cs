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
    public partial class Ventantavj : Form
    {
        public List<Videojuego> lv;

        public Ventantavj(List<Videojuego> lv)
        {
            InitializeComponent();
            this.lv = lv;
            Actualiza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Videojuego v = new Videojuego();
            v.Nombre = textBox1.Text;
            v.Salida = int.Parse(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Add(v.dameDatos());
            lv.Add(v);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            lv[i].Nombre = textBox1.Text;
            lv[i].Salida = int.Parse(textBox2.Text);
            listBox1.Items[i] = lv[i].dameDatos();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                textBox1.Text = lv[i].Nombre;
                textBox2.Text = lv[i].Salida.ToString();
            }
        }

        private void Actualiza()
        {
            listBox1.Items.Clear();
            foreach (Videojuego v in lv)
            {
                listBox1.Items.Add(v.dameDatos());
            }
        }
    }
}
