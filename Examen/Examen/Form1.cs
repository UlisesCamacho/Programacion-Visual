using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public List<Computadora> lc;
        public List<Impresora> li;
        public Form1()
        {
            InitializeComponent();
            lc = new List<Computadora>();
            li = new List<Impresora>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaComputadora vc =new VentanaComputadora(lc);//pasar la lista
            vc.ShowDialog();
            actualiza();
        }
        private void actualiza()
        {
            listBox1.Items.Clear();
            foreach (Computadora c in lc)
            {
                listBox1.Items.Add(c.datos());
               
            }
        }
        private void actualiza1()
        {
            listBox2.Items.Clear();
            foreach (Impresora i in li)
            {
                listBox2.Items.Add(i.datos());
            }
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaImpresora vi =new VentanaImpresora(li);
            vi.ShowDialog();
            actualiza1();

        }
    }
}
