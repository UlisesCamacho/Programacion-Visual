using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreEx
{
    public partial class Form1 : Form
    {
        private List<string> nombres;
        public Form1()
        {
            InitializeComponent();
            nombres = new List<string>();
        }

        private void creaElemento(object sender, EventArgs e)
        {
            nombres.Add(nombre.Text);
            actualiza(true);
        }
        public void actualiza(bool band)
        {
            if(band == true)
            {

                listaNombres.Items.Add(nombre.Text);
                nombre.Text = "";
            }
            else
            {
                listaNombres.Items.Clear();
                foreach(string nombre in nombres)
                {
                    listaNombres.Items.Add(nombre);
                }
            }
            


        }

        private void eliminaElemento(object sender, EventArgs e)
        {
            int i = listaNombres.SelectedIndex;
            nombres.RemoveAt(i);
            listaNombres.Items.RemoveAt(i);
            

        }

        private void ordenaElemento(object sender, EventArgs e)
        {
            nombres.Sort();
            actualiza(false);
        }

        private void modificaElemento(object sender, EventArgs e)
        {
            int i = listaNombres.SelectedIndex;
            nombres[i] = nombre.Text;
            listaNombres.Items.Add(nombre.Text);
            nombre.Text = "";

        }

        private void listaNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listaNombres.SelectedIndex;
            nombre.Text = nombres[i];
            
        }
    }
}
