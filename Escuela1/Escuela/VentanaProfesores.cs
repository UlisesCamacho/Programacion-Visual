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
    public partial class VentanaProfesores : Form
    {
        public List<Profesor> lp;
        public VentanaProfesores()
        {
            InitializeComponent();
            lp = new List<Profesor>();
        }

        private void VentanaProfesores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesor p = new Profesor();
            p.Nombre = textBox1.Text;
            p.ApellidoP = textBox2.Text;
            p.ApellidoM = textBox3.Text;
            p.clave = int.Parse(textBox4.Text);
            lp.Add(p);
            listBox1.Items.Add(p.RegresaNombre());
          
            limpia();

        }
        private void limpia()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            lp.RemoveAt(i);
        }
    }
}
