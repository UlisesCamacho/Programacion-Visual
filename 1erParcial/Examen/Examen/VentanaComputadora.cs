using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class VentanaComputadora : Form
    {
        public List<Computadora> lc;
        public VentanaComputadora(List<Computadora> lc)
        {
            InitializeComponent();
            this.lc = lc;
            actualiza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Computadora c = new Computadora();
            c.modelo = textBox1.Text;
            c.marca = textBox2.Text;
            c.procesador = textBox3.Text;
            lc.Add(c);
            listBox1.Items.Add(c.datos());
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            lc.RemoveAt(i);
            listBox1.Items.RemoveAt(i);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i>-1)
            {
                textBox1.Text = lc[i].modelo;
                textBox2.Text = lc[i].marca;
                textBox3.Text = lc[i].procesador;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            lc[i].modelo = textBox1.Text;
            lc[i].marca = textBox2.Text;
            lc[i].procesador = textBox3.Text;
            listBox1.Items[i] = lc[i].datos();
        }
        private void actualiza()
        {
            listBox1.Items.Clear();
            foreach(Computadora c in lc)
            {
                listBox1.Items.Add(c.datos());
            }
        }
    }
}
