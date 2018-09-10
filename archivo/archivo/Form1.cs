using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace archivo
{
    public partial class Form1 : Form
    {
        public List<Registro> lr;
        public Form1()
        {
            InitializeComponent();
            lr = new List<Registro>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.nombre = textBox1.Text;
            r.clave = int.Parse(textBox2.Text);
            lr.Add(r);
            listBox1.Items.Add(r.datos());
            textBox1.Text = " ";
            textBox2.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            StreamWriter sw =new StreamWriter("archivo.txt");
            foreach(Registro r in lr)
            {
                sw.WriteLine(r.datos());
            }
            sw.Close();
        }
    }
}
