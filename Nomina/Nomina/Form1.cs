using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {
        public List<Registro> lr;

        public Form1()
        {
            InitializeComponent();
            lr = new List<Registro>();//instanciamos la clase
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();// creamos una variable de tipo registro
            r.Nombre = textBox1.Text;
            r.Salario = int.Parse(textBox2.Text);
            lr.Add(r);
            listBox1.Items.Add(r.Datos());
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            lr.RemoveAt(i);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                textBox1.Text = lr[i].Nombre;
                textBox2.Text = lr[i].Salario.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            Registro r = new Registro();
            r.Nombre = textBox1.Text;
            r.Salario = int.Parse(textBox2.Text);
            lr[i] = r;
            listBox1.Items[i] = r.Datos();
        }
    }
}
