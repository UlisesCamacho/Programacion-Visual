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

namespace Tarea
{

    public partial class VentanaCatalogoDesastres : Form
    {
        List<NDesastre> ld;
        public VentanaCatalogoDesastres(List<NDesastre> l)
        {
            InitializeComponent();
            ld = l;
        }

        private void button1_Click(object sender, EventArgs e)
        { //INsertar
            NDesastre d = new NDesastre();
            d.Nombre = textBox1.Text;
            d.Magnitud = int.Parse(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            ld.Add(d);
            listBox1.Items.Add(d.Nombre + " " + d.Magnitud);
        }

        private void button2_Click(object sender, EventArgs e)
        {//Guardar
            StreamWriter sw = new StreamWriter("CatalogoDesastres.txt");

            foreach (NDesastre d in ld)
            {
                sw.WriteLine(d.Nombre);
                sw.WriteLine(d.Magnitud);
            }
            sw.Close();
            MessageBox.Show("Guardado Exitosamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("CatalogoDesastres.txt");
            String line;
            NDesastre d;

            ld.Clear();
            listBox1.Items.Clear();

            while ((line = sr.ReadLine()) != null)
            {
                d = new NDesastre();
                d.Nombre = line;
                d.Magnitud = int.Parse(sr.ReadLine());
                ld.Add(d);
                listBox1.Items.Add(d.Nombre + " " + d.Magnitud);
            }
            sr.Close();

        }
    }
}
