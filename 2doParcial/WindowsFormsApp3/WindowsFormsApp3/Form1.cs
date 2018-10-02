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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cad;
            StreamWriter sw;
            saveFileDialog1.ShowDialog();
            cad = saveFileDialog1.FileName;
            sw = new StreamWriter(cad);
            sw.WriteLine("hola");
            sw.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cad;
            String line;
            StreamReader sr;
            openFileDialog1.ShowDialog();
            cad = openFileDialog1.FileName;
            sr = new StreamReader(cad);
            while ((line = sr.ReadLine()) != null)
            {
                MessageBox.Show(line);
            }
            sr.Close();

            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
