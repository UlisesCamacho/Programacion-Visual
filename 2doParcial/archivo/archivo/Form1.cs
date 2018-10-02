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
                sw.WriteLine(r.nombre);
                sw.WriteLine(r.clave);
            }
            listBox1.Items.Clear();
            sw.Close();
        }
       private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("archivo.txt");
            String linea,linea2;
            //String []arr;
            Registro r;

            lr.Clear();
            listBox1.Items.Clear();

            while ((linea=sr.ReadLine())!=null) // acordarse
            {
                r = new Registro();
                linea2 = sr.ReadLine();

                r.nombre = linea;
                r.clave = int.Parse(linea2);

                lr.Add(r);
                listBox1.Items.Add(r.datos());
            }
            sr.Close();
        }
    }
}
