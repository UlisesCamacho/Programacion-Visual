using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina2
{
   
    public partial class Form1 : Form
    {
        List<Registro> lr;
        public Form1()
        {
            InitializeComponent();
            lr = new List<Registro>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.nombre = textBox1.Text;
            r.salario = int.Parse(textBox2.Text);
            lr.Add(r);
            listBox1.Items.Add(r.Datos());
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.Remove(i);
            lr.RemoveAt(i);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                textBox1.Text = lr[i].nombre;
                textBox2.Text = lr[i].salario.ToString();
            }

        }
    }
}
