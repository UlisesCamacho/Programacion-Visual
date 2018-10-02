using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace ArchivosEstudiar
{
    public partial class Form1 : Form
    {
        public List<Registro> lr;
        public Form1()
        {
            InitializeComponent();
            lr = new List<Registro>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("ArchivoSerializado.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            bf.Serialize(fs, lr);
            fs.Close();
            listBox1.Items.Clear();
            MessageBox.Show("serializado");

           /* BinaryWriter bw = new BinaryWriter(File.Open("ArchivoBinario.txt", FileMode.Append));
            foreach(Registro r in lr)
            {
                bw.Write(r.cadena);
                bw.Write(r.entero);
            }
            bw.Close();
            listBox1.Items.Clear();


           /* StreamWriter sw;
            String ruta;
            saveFileDialog1.ShowDialog();
            ruta = saveFileDialog1.FileName;
            if(ruta!=null)
            {
                sw = new StreamWriter(ruta + ".txt");
                foreach(Registro r in lr)
                {
                    sw.WriteLine(r.cadena);
                    sw.WriteLine(r.entero);
                }
                sw.Close();
                listBox1.Items.Clear();
            }
            */
        
            
            // Guardar
            /*StreamWriter sw = new StreamWriter("archivo.txt");
            foreach(Registro r in lr)
            {
                sw.WriteLine(r.cadena);
                sw.WriteLine(r.entero);
            }
            sw.Close();
            MessageBox.Show("Archivo Guardado");
            listBox1.Items.Clear();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("ArchivoSerializado.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            lr = (List<Registro>)bf.Deserialize(fs);
            fs.Close();
            foreach(Registro r in lr)
            {
                listBox1.Items.Add(r.datos());
            }
            MessageBox.Show("Deserializado");

         /*   BinaryReader br = new BinaryReader(File.Open("ArchivoBinario.txt", FileMode.Open));
            String linea;
            int linea2, i;//para espiar
            Registro r;
            lr.Clear();
            listBox1.Items.Clear();
            while((i=br.PeekChar())!=-1)
            {
                r = new Registro();
                linea = br.ReadString();
                linea2 = br.ReadInt32();
                r.cadena = linea;
                r.entero = linea2;
                lr.Add(r);
                listBox1.Items.Add(r.datos());

            }
            br.Close();

           /* StreamReader sr;
            Registro r;
            String linea, linea2, ruta;
            openFileDialog1.ShowDialog();
            ruta = openFileDialog1.FileName;
            lr.Clear();
            listBox1.Items.Clear();
            if(ruta!="" && ruta.Substring(ruta.Length-3)=="txt")
            {
                sr = new StreamReader(ruta);
                while((linea=sr.ReadLine())!=null)
                {
                    r = new Registro();
                    linea2 = sr.ReadLine();
                    r.cadena = linea;
                    r.entero = int.Parse(linea2);
                    lr.Add(r);
                    listBox1.Items.Add(r.datos());

                }
                sr.Close();

            }*/
            
            
            // abrir
           /* StreamReader sr = new StreamReader("archivo.txt");
            Registro r;
            String linea, linea2;
            lr.Clear();
            listBox1.Items.Clear();
            while((linea=sr.ReadLine())!=null)
            {
                r = new Registro();
                linea2 = sr.ReadLine();
                r.cadena = linea;
                r.entero = int.Parse(linea2);
                lr.Add(r);
                listBox1.Items.Add(r.datos());

               
            }
            sr.Close();*/
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.cadena = textBox1.Text;
            r.entero = int.Parse(textBox2.Text);
            lr.Add(r);
            listBox1.Items.Add(r.datos());
            textBox1.Text = " ";
            textBox2.Text = " ";
         
        }
    }
}
