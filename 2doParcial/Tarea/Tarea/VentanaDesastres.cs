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
using System.Runtime.Serialization.Formatters.Binary;

namespace Tarea
{
    public partial class VentanaDesastres : Form
    {
        private List<Ubicacion> lu;
        private List<NDesastre> ld;
        private List<DesastreUbicado> ldu;

        public VentanaDesastres(List<Ubicacion> lu, List<NDesastre> ld)
        {
            InitializeComponent();
            this.lu = lu;
            this.ld = ld;
            ldu = new List<DesastreUbicado>();

            foreach (Ubicacion u in lu)
            {
                comboBox1.Items.Add(u.Nombre);
            }

            foreach (NDesastre d in ld)
            {
                comboBox2.Items.Add(d.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            int i2 = comboBox2.SelectedIndex;

            DesastreUbicado du = new DesastreUbicado();
            du.n = ld[i2];
            du.u = lu[i];
            ldu.Add(du);
            listBox1.Items.Add(du.n.Nombre + " " + du.u.Nombre);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("desastresubicados.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            bf.Serialize(fsout, ldu);
            fsout.Close();
            MessageBox.Show("Serializado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("desastresubicados.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            listBox1.Items.Clear();
            ldu = (List<DesastreUbicado>)bf.Deserialize(fsout);
            fsout.Close();
            foreach (DesastreUbicado du in ldu)
            {
                listBox1.Items.Add(du.n.Nombre + " " + du.u.Nombre);
            }
        }
    }
}
