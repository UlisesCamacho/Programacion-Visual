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
    public partial class Registro : Form
    {
        String cadconexion;
        OleDbConnection con;
        OleDbCommand comand;
        OleDbDataReader lector;
        String id;


        public Registro()
        {
            InitializeComponent();
            cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\sexshop.accdb; Persist Security Info=False;";
            Muestra();
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
            listBox1.Items.Clear();
            while (lector.Read())
            {
                listBox1.Items.Add(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " "+lector.GetValue(2).ToString());
            }
            desconectar();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Agregar

            String consulta = "Insert into Productos(Nombre, Precio, Descripcion) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            conectar();
            comand = new OleDbCommand(consulta, con);
            comand.ExecuteNonQuery();
            desconectar();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Muestra();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eliminar
            int aux = listBox1.SelectedIndex;
            
            String consulta;
            if (aux > -1)
            {
                id = listBox1.Items[aux].ToString().Split(' ')[0];
                consulta = "Delete from Productos Where IdProducto=" + id;
                conectar();
                comand = new OleDbCommand(consulta, con);
                comand.ExecuteNonQuery();
                desconectar();
                Muestra();
            }



            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //actualizar
            
            int aux = listBox1.SelectedIndex;
           
            String consulta;
            if (aux > -1)
            {
                id = listBox1.Items[aux].ToString().Split(' ')[0];

                consulta = "Update Productos set Nombre='"+textBox1.Text+"', Precio='"+textBox2.Text+"', Descripcion='"+textBox3.Text+"'  Where IdProducto=" + id;
                conectar();
                comand = new OleDbCommand(consulta, con);
                comand.ExecuteNonQuery();
                desconectar();
                Muestra();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String consulta;
            int aux = listBox1.SelectedIndex;
            
            
            if (aux > -1)
            {
                id = listBox1.Items[aux].ToString().Split(' ')[0];
                consulta = "Select * From Productos where IdProducto=" + id;
                conectar();
                comand = new OleDbCommand(consulta, con);
                lector = comand.ExecuteReader();

                while (lector.Read())
                {
                    textBox1.Text = lector.GetValue(1).ToString();
                    textBox2.Text = lector.GetValue(2).ToString();
                    textBox3.Text = lector.GetValue(3).ToString();
                }
                desconectar();
            }
        }




    }
}
