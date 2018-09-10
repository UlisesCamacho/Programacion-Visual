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
    public partial class VentanaImpresora : Form
    {
        public List<Impresora> li;
        public VentanaImpresora(List<Impresora>li)
        {
            InitializeComponent();
            this.li = li;
            actualiza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impresora i = new Impresora();
            i.modelo = textBox1.Text;
            i.marca = textBox2.Text;
            i.numeroDeImpresiones =Convert.ToInt32(textBox3.Text);
            li.Add(i);
            listBox1.Items.Add(i.datos());
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";

        }

        private void actualiza()
        {
            listBox1.Items.Clear();
            foreach (Impresora i in li)
            {
                listBox1.Items.Add(i.datos());
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            if (a > -1)
            {
                textBox1.Text = li[a].modelo;
                textBox2.Text = li[a].marca;
                textBox3.Text = li[a].numeroDeImpresiones.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            li[a].modelo = textBox1.Text;
            li[a].marca = textBox2.Text;
            li[a].numeroDeImpresiones = Convert.ToInt32(textBox3.Text);
            listBox1.Items[a] = li[a].datos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            li.RemoveAt(a);
            listBox1.Items.RemoveAt(a);
        }
    }
}

