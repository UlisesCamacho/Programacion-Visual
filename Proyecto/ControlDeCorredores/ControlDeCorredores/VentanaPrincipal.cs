using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ControlDeCorredores
{
    public partial class VentanaPrincipal : Form
    {
        public List<Usuario> lu;
        public VentanaPrincipal(List<Usuario> lu)
        {
            InitializeComponent();
            this.lu = lu;
            
            actualiza();
        }


        private void actualiza()
        {

            listBox1.Items.Clear();
            foreach(Usuario u in lu)
            {
                listBox1.Items.Add("Nombre: " + u.Nombre + "Edad: " + u.Edad +" Sexo "+ u.Sexo);
            }
            
        }

        
    }
}
