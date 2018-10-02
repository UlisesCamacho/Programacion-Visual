using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen2
{
    public partial class VentanaConsulta : Form
    {
        public List<Doctor> ld;
        public List<Paciente> lp;
        public VentanaConsulta(List<Doctor> ld)
        {
            InitializeComponent();
            this.ld = ld;
            lp = new List<Paciente>();
            foreach (Doctor d in ld)
            {
                comboBox1.Items.Add(d.NombreDoc);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            //int i2 = comboBox2.SelectedIndex;

            Paciente p = new Paciente();
            p.nombrePaciente = textBox1.Text;
            p.fecha = textBox2.Text;
            p.hora = textBox3.Text;
            p.d.NombreDoc = ld[i].NombreDoc;
            lp.Add(p);
            listBox1.Items.Add(" Doctor:" + " " 
                + p.d.NombreDoc + 
                " Paciente: "+ 
                p.nombrePaciente +
                " Fecha: " + p.fecha
                + "  Hora: " +
                p.hora + " ");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i = comboBox1.SelectedIndex;
            String apoyo;
            apoyo = comboBox1.Items[i].ToString();
            StreamWriter sw = new StreamWriter(apoyo + ".txt");

            foreach (Paciente p in lp)
            {
                sw.WriteLine(p.nombrePaciente);
                sw.WriteLine(p.fecha);
                sw.WriteLine(p.hora);
            }
            sw.Close();
            MessageBox.Show("Archivo Guardado");
            listBox1.Items.Clear(); 



        }
    }
}
