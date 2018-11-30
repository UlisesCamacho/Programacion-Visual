using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCorredores
{
    public partial class Cronometro : Form
    {
        public Cronometro()
        {
            InitializeComponent();
        }
        int seg;
        int min;
        int hrs;
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="Iniciar")
            {
                timer1.Start();
                button2.Enabled = true;
                button1.Text = "Restablecer";
            
            }
            else
            {
                timer1.Stop();
                seg = 0;
                min = 0;
                hrs = 0;
                label1.Text = "00:00:00";
                button2.Enabled = false;
                button2.Text = "Pausar";
                button1.Text = "Iniciar";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="Pausar")
            {
                timer1.Stop();
                button2.Text = "Reanudar";

            }
            else
            {
                timer1.Start();
                button2.Text = "Pausar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg += 1;

            string segundos = seg.ToString(); ;
            string minutos = min.ToString();
            string horas = hrs.ToString();

            if (seg < 10) { segundos = "0" + seg.ToString(); }
            if (min < 10) { minutos = "0" + min.ToString(); }
            if (hrs < 10) { horas = "0" + hrs.ToString(); }

            label1.Text = horas + ":" + minutos + ":" + segundos;

            if (seg == 60)
            {
                min += 1;
                seg = 0;
            }
            if(min==60)
            {
                hrs += 1;
                min = 0;
            }
        }
    }
}
