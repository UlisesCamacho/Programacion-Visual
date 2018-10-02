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

namespace TareaFutbol
{
    public partial class VentanaEquipo : Form
    {
        List<Equipo> le;
        public VentanaEquipo(List<Equipo> le)
        {
            InitializeComponent();
            this.le = le;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipo t = new Equipo();
            t.NombreEquipo = textBox1.Text;
            le.Add(t);
            listBox1.Items.Add(t.NombreEquipo);
            textBox1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            le.RemoveAt(i);            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Equipo.txt");
           foreach(Equipo t in le)
            {
                sw.WriteLine(t.NombreEquipo);
            }
            sw.Close();
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Equipo.txt");
            String Equipo1;
            Equipo t;
            le.Clear();
            listBox1.Items.Clear();
            while((Equipo1=sr.ReadLine())!=null)
            {
                t = new Equipo();
                t.NombreEquipo = Equipo1;
                le.Add(t);
                listBox1.Items.Add(t.NombreEquipo);

            }
            sr.Close();

        }
    }
}
