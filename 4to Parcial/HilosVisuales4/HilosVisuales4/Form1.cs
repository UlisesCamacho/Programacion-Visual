using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HilosVisuales4
{
    public partial class Form1 : Form
    {
        Thread hilo = null;
        delegate void SetTextCallback();


        public Form1()
        {
            InitializeComponent();
        }

        private void bHilo_Click(object sender, EventArgs e)
        {
            this.hilo = new Thread(new ThreadStart(this.saluda));
            this.hilo.Start();
        }
        private void saluda()
        {
            if (textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(saludaDelegado);
                this.Invoke(d);
            }
            
        }

        private void saludaDelegado()
        {
            this.textBox1.Text = "hola";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.textBox1.Text = "Esto fue hecho mediante Trabajadores secundarios";
		
        }

      
    }
}
