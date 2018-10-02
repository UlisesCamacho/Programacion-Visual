using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        List<Ubicacion> lu;
        List<NDesastre> ld;
        public Form1()
        {
            InitializeComponent();
            lu = new List<Ubicacion>();
            ld = new List<NDesastre>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCatalogoDesastres v = new VentanaCatalogoDesastres(ld);
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatalogoUbicacion c = new CatalogoUbicacion(lu);
            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaDesastres v = new VentanaDesastres(lu, ld);
            v.ShowDialog();
        }
    }
}
