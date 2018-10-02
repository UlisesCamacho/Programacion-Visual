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
    public partial class Form1 : Form
    {
        List<Alumno> la;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaAlumno v = new VentanaAlumno();
            v.ShowDialog();
            la = v.la; // copiando lista de alumnos a ventana "principal"
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grupos v = new Grupos(la);
            v.ShowDialog();
        }
    }
}
