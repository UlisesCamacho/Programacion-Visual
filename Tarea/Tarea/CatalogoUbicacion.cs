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

namespace Tarea
{
    public partial class CatalogoUbicacion : Form
    {
        List<Ubicacion> lu;
        public CatalogoUbicacion(List<Ubicacion> l)
        {
            InitializeComponent();
            lu = l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ubicacion u = new Ubicacion();
            u.Nombre = textBox1.Text;
            u.Poblacion= int.Parse(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            lu.Add(u);
            listBox1.Items.Add(u.Nombre + " " + u.Poblacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open("CatalogoUbicacion.txt", FileMode.Append));
            foreach (Ubicacion u in lu)
            {
                writer.Write(u.Nombre);
                writer.Write(u.Poblacion);
            }
            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String line;
            int pob;
            int i;
            Ubicacion u;

            BinaryReader reader = new BinaryReader(File.Open("CatalogoUbicacion.txt",FileMode.Open));

            lu.Clear();
            listBox1.Items.Clear();


            while ((i = reader.PeekChar()) != -1)
            {
                line = reader.ReadString();
                pob = reader.ReadInt32();
                u = new Ubicacion();
                u.Nombre = line;
                u.Poblacion = pob;
                lu.Add(u);
                listBox1.Items.Add(u.Nombre + " " + u.Poblacion);
            }
            reader.Close();
        }
    }
}
