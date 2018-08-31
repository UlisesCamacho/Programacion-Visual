﻿using System;
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
        List<Profesor> lp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaProfesores v = new VentanaProfesores();
            v.ShowDialog();
            lp = v.lp;// copiando lista de profesores a ventana principal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaAlumno v = new VentanaAlumno();
            v.ShowDialog();
            la = v.la; // copiando lista de alumnos a ventana "principal"
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaGrupos v = new VentanaGrupos(la,lp);
            v.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
