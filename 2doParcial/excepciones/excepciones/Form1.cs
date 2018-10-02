using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 98, b = 0;
            double result = 0;

            try
            {
                result = SafeDivision(a, b);
                MessageBox.Show(a+" divided by "+b+" = " +result);
            }
            catch 
            {
                MessageBox.Show ("Attempted divide by zero.");
            }
        }

        public double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new ExcepcionDivision();
            return x / y;
        }
    }
}
