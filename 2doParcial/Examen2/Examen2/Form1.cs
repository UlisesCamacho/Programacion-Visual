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

namespace Examen2
{
    public partial class Form1 : Form
    {
        List<Doctor> ld;
        public Form1()
        {
            InitializeComponent();
            ld = new List<Doctor>();

          StreamReader sr = new StreamReader("Doctores.txt");// funciona pero cuando ya se gurdaron doctores
            Doctor d;
            String linea, linea2;
            ld.Clear();
            listBox1.Items.Clear();
            while ((linea = sr.ReadLine()) != null)
            {
                d = new Doctor();
                linea2 = sr.ReadLine();
                d.NombreDoc = linea;
                d.CedulaDoc = int.Parse(linea2);
                ld.Add(d);
                listBox1.Items.Add(d.NombreDoc + d.CedulaDoc);


            }
            sr.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.NombreDoc = textBox1.Text;
            d.CedulaDoc = int.Parse(textBox2.Text);
            ld.Add(d);
            listBox1.Items.Add(d.NombreDoc + " " + d.CedulaDoc);
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Doctores.txt");
            foreach (Doctor d in ld)
            {
                sw.WriteLine(d.NombreDoc);
                sw.WriteLine(d.CedulaDoc);
            }
            sw.Close();
            MessageBox.Show("Archivo Guardado");
            listBox1.Items.Clear(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaConsulta vc = new VentanaConsulta(ld);
            vc.ShowDialog();
        }
    }
}
