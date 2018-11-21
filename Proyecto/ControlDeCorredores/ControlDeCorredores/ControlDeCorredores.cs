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
    public partial class ControlDeCorredores : Form
    {
        String cadconexion;
        OleDbConnection con;
        OleDbCommand comand;
        OleDbDataReader lector;
        String id;

        public List<Usuario> lu;

        public ControlDeCorredores()
        {
            InitializeComponent();
            lu = new List<Usuario>();
            cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\ControlCorredores.accdb; Persist Security Info=False;";
            Muestra();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            String consulta = "Insert into Productos(Nombre, Precio, Descripcion) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            conectar();
            comand = new OleDbCommand(consulta, con);
            comand.ExecuteNonQuery();
            
            Usuario u = new Usuario();
            u.Nombre =textBox1.Text;
            u.Edad =int.Parse(textBox2.Text);
            u.Sexo = textBox3.Text;
            lu.Add(u);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            desconectar();
            VentanaPrincipal vp = new VentanaPrincipal(lu);
            vp.ShowDialog();

            
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
           // listBox1.Items.Clear();
            while (lector.Read())
            {
                listBox1.Items.Add(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString());
                MessageBox.Show("se agrego");
            }
            desconectar();

        }
    }
}
