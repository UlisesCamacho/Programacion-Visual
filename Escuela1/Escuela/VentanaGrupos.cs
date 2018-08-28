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
    public partial class VentanaGrupos : Form
    {
        List<Alumno> la;
        private List<Alumno> alumnoGrupo;
        private Profesor profesor;
        List<Profesor> lp;
        Grupo grupo;// para crear lista de grupo
        List<Grupo> lg = new List<Grupo>();
        public VentanaGrupos(List<Alumno>la, List<Profesor>lp)
        {
            InitializeComponent();
            this.la = la;
            this.lp = lp;
            alumnoGrupo = new List<Alumno>();
            CargaAlumnos();
            CargaProfesores();
            
        }
        public void CargaAlumnos()
        {
            foreach(Alumno a in la)
            {

                listBox1.Items.Add(a.regresaNombre());

            }
        }
        public void CargaProfesores()
        {
            foreach (Profesor p in lp)
            {

                comboBox1.Items.Add(p.RegresaNombre());
               
            }
        }

        private void Grupos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Derecha
        private void button3_Click(object sender, EventArgs e)
        {
           // listBox2.Text = listBox1.Text;
            
            foreach(Alumno aux in la)
            {
                if(listBox1.Text == aux.regresaNombre())
                {
                    alumnoGrupo.Add(aux);
                    listBox2.Items.Add(aux.regresaNombre());
                }
            }

            

        }
        
        private void guardaGrupo(object sender, EventArgs e)
        {
            int clave;
            if (textBox1.Text != "")
            {
                clave = Int32.Parse(textBox1.Text); // Convert.toInt32(textbox1.text);
                
                grupo = new Grupo(clave,alumnoGrupo,profesor);
                lg.Add(grupo); 
                listBox3.Items.Add(textBox1.Text);

            }
        }

        private void SeleccionaProfesor(object sender, EventArgs e)
        {
            foreach(Profesor aux in lp)
            {
                if(comboBox1.SelectedItem.ToString() == aux.RegresaNombre())
                {
                    profesor = aux;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(Grupo g in lg)
            {
                MessageBox.Show("Clave: " + g.dameClave());
                foreach(Alumno a in g.dameListaAlumno())
                {
                    MessageBox.Show("Alumno" + a.regresaNombre());
                }
                MessageBox.Show("Profesor: " + g.dameProfesor().RegresaNombre());
            }
        }
    }
}
