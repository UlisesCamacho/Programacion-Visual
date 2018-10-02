using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Escuela
{
    public partial class Form1 : Form
    {
        List<Alumno> la;
        List<Profesor> lp;
        List<Grupo> lg;
        public Form1()
        {
            InitializeComponent();
            lg = new List<Grupo>();
            la = new List<Alumno>();
            lp = new List<Profesor>();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.AccessibleName)
            {

                case "Abrir":
                    MessageBox.Show("Abrir");
                    AbrirArchivo();
                    break;
                case "gUARDAR":
                   
                    MessageBox.Show("Guardar");
                    GuardarArchivo();
                    break;
            }
        }
        private void GuardarArchivo()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;
            try { 
                if (la != null)
            {
                fs = new FileStream("Alumno.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                bf.Serialize(fs, la);
                fs.Close();

            }

            if (lp != null)
            {
                fs = new FileStream("Profesor.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                bf.Serialize(fs, lp);
                fs.Close();
            }
            if (lg != null)
            {
                fs = new FileStream("Grupo.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                bf.Serialize(fs, lg);
                fs.Close();
            } }
            catch { }
        
        }
        private void AbrirArchivo()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;
            try {
                
                    fs = new FileStream("Alumno.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                    la = (List<Alumno>)bf.Deserialize(fs);
                    fs.Close();
                
              
                    fs = new FileStream("Profesor.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                    lp = (List<Profesor>)bf.Deserialize(fs);
                    fs.Close();


                    fs = new FileStream("Grupo.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                    lg = (List<Grupo>)bf.Deserialize(fs);
                    fs.Close();


            }
            catch {
                
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            switch(comboBox1.Text)
            {
                case "Alumno":
                   foreach(Alumno a in la)
                    {
                        listBox1.Items.Add(a.nombre + " " +  a.apellidoP + " " +  a.apellidoM + " " +  a.clave );
                        
                        
                    }
                    break;
                case "Profesor":
                    foreach(Profesor p in lp)
                    {
                        listBox1.Items.Add(p.Nombre + " " + p.ApellidoP + " " + p.ApellidoM + " " + p.clave);
                    }
                    break;
                case "Grupo":
                    foreach(Grupo g in lg)
                    {
                        listBox1.Items.Add(g.dameClave());
                    }
                    break;
            }

            }

            

        }
    }

