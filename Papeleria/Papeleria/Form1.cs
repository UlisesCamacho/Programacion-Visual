using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papeleria
{
    public partial class Form1 : Form
    {
        List<Articulo> la;

        public Form1()
        {
            InitializeComponent();
            la = new List<Articulo>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo a= new Articulo();
            a.Nombre = textBox1.Text;
            a.Cantidad = int.Parse(textBox2.Text);

            la.Add(a);
            /*listBox1.Items.Add(a.Nombre 
                    + " " 
                    + a.Cantidad.ToString())*/
            Actualiza();
        }

        public void Actualiza()
        {
            listBox1.Items.Clear();
            foreach (Articulo a in la)
            {
                listBox1.Items.Add(a.Nombre 
                    + " " 
                    + a.Cantidad.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            la.RemoveAt(i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                la[i].Nombre = textBox1.Text;
                la[i].Cantidad = int.Parse(textBox2.Text);
            }
            /*
             Articulo a=new Articulo();
             a.Nombre= = textBox1.Text;
             a.Cantidad=int.Parse(textBox2.Text);
             la[i]=a;
             */
            Actualiza();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i > -1)
            {
                textBox1.Text = la[i].Nombre;
                textBox2.Text = la[i].Cantidad.ToString();
            }
        }
    }
    }

