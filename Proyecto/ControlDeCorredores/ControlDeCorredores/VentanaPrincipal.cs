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
        String cadconexion;
        OleDbConnection con;
        OleDbCommand comand;
        OleDbDataReader lector;
        String id;
        public List<Usuario> lu;
        public VentanaPrincipal(List<Usuario> lu)
        {
            InitializeComponent();
            this.lu = lu;
            cadconexion= @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\ControlCorredores.accdb; Persist Security Info=False;";
            actualiza();
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
            String consulta = "Select * From Corredores";
            conectar();
            comand = new OleDbCommand(consulta, con);
            lector = comand.ExecuteReader();
            listBox1.Items.Clear();
            while (lector.Read())
            {
                listBox1.Items.Add(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() +  " " + lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " + lector.GetValue(4).ToString() + " " +lector.GetValue(5).ToString());
            }
            desconectar();

        }

        private void actualiza()
        {
            comboBox1.Items.Clear();
            foreach(Usuario u in lu)
            {
                comboBox1.Items.Add(" NOMBRE: " + u.Nombre + " EDAD: " + u.Edad + " SEXO: " + u.Sexo);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Agregar
            String consulta = "Insert into Corredores(Nombre, Edad, Sexo, Distancia, Tiempo, CaloriasQuemadas, Pasos, VelocidadPromedio) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            conectar();
            comand = new OleDbCommand(consulta, con);
            comand.ExecuteNonQuery();
            desconectar();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            Muestra();
   }
     private void button2_Click_1(object sender, EventArgs e)
        {
            //eliminar
            int aux = listBox1.SelectedIndex;

            String consulta;
            if (aux > -1)
            {
                id = listBox1.Items[aux].ToString().Split(' ')[0];
                consulta = "Delete from Corredores Where Id=" + id;
                conectar();
                comand = new OleDbCommand(consulta, con);
                comand.ExecuteNonQuery();
                desconectar();
                Muestra();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //  Modificar
            int aux = listBox1.SelectedIndex;
            String consulta;
            if (aux > -1)
            {
                id = listBox1.Items[aux].ToString().Split(' ')[0];
                consulta = "Update Corredores set Nombre='" + textBox1.Text + "', Edad='" + textBox2.Text + "', Sexo='" + textBox3.Text + "', Distancia='" + textBox4.Text + "', Tiempo='" + textBox5.Text + "', Calorias Quemadas='" + textBox7.Text + "', Pasos='" + textBox8.Text + "', Velocidad Promedio='" + textBox9.Text + "'  Where Id=" + id;
                conectar();
                comand = new OleDbCommand(consulta, con);
                comand.ExecuteNonQuery();
                desconectar();
                Muestra();
            }
        }
      private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String consulta;
            int aux = listBox1.SelectedIndex;
             id = listBox1.Items[aux].ToString().Split(' ')[0]; 
             consulta = "Select * From Corredores where Id=" + id;
             conectar();
             comand = new OleDbCommand(consulta, con);
             lector = comand.ExecuteReader();

             while (lector.Read())
             {
                 textBox1.Text = lector.GetValue(1).ToString();
                 textBox2.Text = lector.GetValue(2).ToString();
                 textBox3.Text = lector.GetValue(3).ToString();
                textBox4.Text = lector.GetValue(4).ToString();
                textBox5.Text = lector.GetValue(5).ToString();

            }
             desconectar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = comboBox1.SelectedIndex;
            if (aux > -1)
            {
                textBox1.Text = lu[aux].Nombre;
                textBox2.Text = lu[aux].Edad.ToString();
                textBox3.Text = lu[aux].Sexo;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int peso;
            int calorias;
            int vel;
            int pasos;
            int distancia;
            int tiempo;

            distancia = int.Parse(textBox4.Text);
            tiempo = int.Parse(textBox5.Text);
            peso = int.Parse(textBox6.Text);

            calorias = (peso * distancia)/tiempo;
            pasos = distancia * tiempo * 100;
            vel = distancia / tiempo;

            textBox7.Text = calorias.ToString();
            textBox8.Text = pasos.ToString();
            textBox9.Text = vel.ToString();
        }

    }
 }


