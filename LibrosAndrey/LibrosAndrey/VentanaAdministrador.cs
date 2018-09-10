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
    public partial class VentanaAdministrador : Form
    {
        private String nombre;
        private int year;
        public VentanaAdministrador()
        {
            InitializeComponent();
        }

        private void añadir(object sender, EventArgs e)
        {
            this.Close();
        }
        public String dameNombre()
        {
            nombre = textBox1.Text;
            return nombre;
        }
        public int dameYear()
        {
            year = Convert.ToInt32(textBox2.Text);
            return year;
        }
    }
}
