using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ControlDeCorredores
{
    public partial class ControlDeCorredores : Form
    {

        public List<Usuario> lu;
        public ControlDeCorredores()
        {
            InitializeComponent();
            lu = new List<Usuario>();
            timer1.Enabled = true;
            timer1.Interval = 25;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || comboBox2.Text != "")
            {
                Usuario u = new Usuario();
                u.Nombre = textBox1.Text;
                u.Edad = int.Parse(textBox2.Text);
                u.Sexo = comboBox2.Text;
                lu.Add(u);
                textBox1.Text = " ";
                textBox2.Text = " ";
                VentanaPrincipal vp = new VentanaPrincipal(lu);
                vp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Completar campos");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            VentanaPrincipal vp = new VentanaPrincipal(lu);
            vp.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}