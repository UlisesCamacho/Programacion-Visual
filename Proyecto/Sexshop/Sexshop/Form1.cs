using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sexshop
{
    public partial class Form1 : Form
    {
        String cadconexion;
        OleDbConnection con;
        OleDbCommand comand;
        OleDbDataReader lector;
        public Form1()
        {
            InitializeComponent();
            cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\sexshop.accdb; Persist Security Info=False;";
            Muestra();
        }

        private void bRegistra_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.ShowDialog();
            
        }

        public void conectar()
        {
            try
            {
                con = new OleDbConnection(cadconexion);
                con.Open();
            }
            catch
            {
                MessageBox.Show("No me pude conectar");
            }
        }
        public void desconectar()
        {
            con.Close();
        }

        public void Muestra()
        {
            String consulta = "Select * From Productos";
            conectar();
            comand = new OleDbCommand(consulta, con);
            lector = comand.ExecuteReader();

            while (lector.Read())
            {
                listBox1.Items.Add(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString());
            }
            desconectar();

        }
    }
}
