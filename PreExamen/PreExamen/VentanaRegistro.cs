using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExamen
{
    public partial class VentanaRegistro : Form
    {
        public List<Videojuego> lvi;
        public VentanaRegistro()
        {
            InitializeComponent();
            lvi = new List<Videojuego>();
        }

        private void VentanaRegistro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Videojuego v = new Videojuego();
            v.nombre = textBox1.Text;
            v.año = int.Parse(textBox2.Text);
            lvi.Add(v);
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {




        }
    }
}
