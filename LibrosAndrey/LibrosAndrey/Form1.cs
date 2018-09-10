using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosAndrey
{
    public partial class Form1 : Form
    {
        public Libro libro;
        public List<Libro> ll;
        public List<Libro> lt;
        public Form1()
        {
            InitializeComponent();
            ll = new List<Libro>();
            lt = new List<Libro>();
        }
        

        private void administra(object sender, EventArgs e)
        {
            VentanaAdministrador va = new VentanaAdministrador();
            va.ShowDialog();
            int y;
            String n;

            if(va.DialogResult == DialogResult.OK)
            {
                y = va.dameYear();
                n = va.dameNombre();
                libro = new Libro(n, y);
                ll.Add(libro);
                actualiza();
              
            }
        }
        private void actualiza()
        {
            listBox1.Items.Clear();
            foreach(Libro l in ll)
            {
                listBox1.Items.Add(l.datos());
            }
        }

        private void renta(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int i = listBox1.SelectedIndex;
                lt.Add(ll[i]);
                ll.RemoveAt(i);
                actualiza();
            }
            else
                MessageBox.Show("Ya no hay libros que rentar");
        }
    }
}
