using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class VentanaAlumno : Form
    {
        public List<Alumno> la;
        public VentanaAlumno()
        {
            InitializeComponent();
            la = new List<Alumno>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.nombre = textBox1.Text;
            a.apellidoP = textBox2.Text;
            a.apellidoM = textBox3.Text;
            a.clave = int.Parse(textBox4.Text);
            la.Add(a);
            listBox1.Items.Add(a.regresaNombre());
            limpia();
            //la.Sort();
            la = la.OrderBy(x => x.clave).ToList();
            foreach (Alumno c in la)
            {
                MessageBox.Show("clave" + c.clave);
            }

        }
        private void limpia()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            la.RemoveAt(i);
        }

        private void VentanaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
