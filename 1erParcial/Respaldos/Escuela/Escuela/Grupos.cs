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
    public partial class Grupos : Form
    {
        List<Alumno> la;
        List<Profesor> lp;
        public Grupos(List<Alumno>la)
        {
            InitializeComponent();
            this.la = la;
            CargaAlumnos();
            
        }
        public void CargaAlumnos()
        {
            foreach(Alumno a in la)
            {

                listBox1.Items.Add(a.regresaNombre());

            }
        }

        private void Grupos_Load(object sender, EventArgs e)
        {

        }
    }
}
