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
using OfficeOpenXml;
using System.IO;


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
                // Tabla
                try
                {    //tabla.nombre = lector.GetValue(0).ToString() 
                    Usuario u = new Usuario();

                    u.Nombre = lector.GetValue(1).ToString();
                    u.Edad = int.Parse(lector.GetValue(2).ToString());
                    u.Sexo = lector.GetValue(3).ToString();
                    u.Distancia = float.Parse(lector.GetValue(4).ToString());
                    u.Tiempo = float.Parse(lector.GetValue(5).ToString());
                    u.Calorias = float.Parse(lector.GetValue(6).ToString());
                    u.Pasos = float.Parse(lector.GetValue(7).ToString());
                    u.Vel = float.Parse(lector.GetValue(7).ToString());
                    lu.Add(u);
                    listBox1.Items.Add(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() /* + " " + lector.GetValue(4).ToString() + " " +lector.GetValue(5).ToString()*/);
                }
                catch { }
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
            textBox6.Text = "";
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
            if (textBox6.Text != "" || textBox11.Text != "")
            {
                calcular();
            }
            else
            {
                MessageBox.Show("Introducir peso y estatura para calcular");
            }
        }
        private void calcular()
        {
            float peso;
            float altura;
            float calorias;
            float vel;
            float pasos;
            float distancia;
            float tiempo;
            int edad;

            Random ra = new Random();
            int r = ra.Next(1, 6);

            distancia = float.Parse(textBox4.Text);
            tiempo = float.Parse(textBox5.Text);
            peso = float.Parse(textBox6.Text);
            altura = float.Parse(textBox11.Text);
            edad =int.Parse(textBox2.Text);
            calorias = 0.0f;

            if(textBox3.Text=="Hombre")
            {
                MessageBox.Show(" es Hombre");
                calorias = (13.75f * peso) + (5 * altura) - (6.76f * edad)+66;    //(13,75 × el peso) +(5 × la estatura) -(6,76 × la edad) +66.

            }
            else {

                if(textBox3.Text=="Mujer")
                {
                    MessageBox.Show("es mujer");
                    calorias = (9.56f * peso) + (1.85f * altura) - (4.68f * edad) + 655;// (9,56 × el peso) +(1,85 × la estatura) -(4,68 × la edad) +655.
                }
                else
                {
                    MessageBox.Show("Tenemos un problema aqui");
                }
            }

            //calorias = (peso * distancia) / tiempo;
            pasos = distancia*2;
            vel = distancia / tiempo;

            textBox7.Text = calorias.ToString();//calorias.ToString();
            textBox8.Text = pasos.ToString();
            textBox9.Text = vel.ToString();

            //meter random para los mensajes
            switch (r)
            {
                case 1:
                    if (distancia > 9 && tiempo < 50)
                    {
                        MessageBox.Show("Excelente tiempo y distancia: " + " " + textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Vamos si se puede, mejora tu tiempo, actualmente es de:"+ " " + textBox5.Text);
                    }
                    break;
                case 2:
                    if(calorias>2000)
                    {
                        MessageBox.Show("Quemaste: " + textBox7.Text + ", muy bien");
                    }
                    else
                    {
                        MessageBox.Show("Venga puedes dar mas " + textBox1.Text +"!!!");
                    }
                    break;
                case 3:
                    if(vel>1)
                    {
                        MessageBox.Show("tu velocidad es de: " + textBox6.Text);
                    }
                    else
                    {
                        MessageBox.Show("Tienes que correr mas rapido");
                    }
                    break;
                case 4:
                    if(pasos>1000)
                    {
                        MessageBox.Show("tus pasos son: " + textBox8.Text + ", muy bien");
                    }
                    else
                    {
                        MessageBox.Show("tienes que mejorar la zancada");
                    }
                    break;
            }
        }       

        private void button6_Click(object sender, EventArgs e)
        {
           // int count = int.Parse(textBox10.Text);
          //  count++;
          //  textBox10.Text = count.ToString();

            using (ExcelPackage excel = new ExcelPackage())
            {

               

                FileInfo excelFile = new FileInfo(@".\ControlDeCorredores.xlsx");
              //  excelFile.OpenWrite();
               
                    excel.Workbook.Worksheets.Add("Corredores");
                      var worksheet = excel.Workbook.Worksheets["Corredores"];

                int i= 2;
                foreach (Usuario aux in lu)
                {

                    worksheet.Cells["B" + i].Value =aux.Nombre;
                    worksheet.Cells["C" + i].Value = aux.Edad;
                    worksheet.Cells["D" + i].Value = aux.Sexo;
                    worksheet.Cells["E" + i].Value = aux.Distancia;
                    worksheet.Cells["F" + i].Value = aux.Tiempo;
                    worksheet.Cells["G" + i].Value = aux.Calorias;
                    worksheet.Cells["H" + i].Value = aux.Pasos;
                    worksheet.Cells["I" + i].Value = aux.Vel;
                    //worksheet.Cells["B" + i].Value = aux.Nombre;

                   // MessageBox.Show(" se esta insertando");
                   // worksheet.Cells
                   i++;
                   
                }

                worksheet.Cells["A1"].Value = "ID";
                      worksheet.Cells["B1"].Value = "Nombre";
                      worksheet.Cells["C1"].Value = "Edad";
                      worksheet.Cells["D1"].Value = "Sexo";
                      worksheet.Cells["E1"].Value = "Distancia";
                      worksheet.Cells["F1"].Value = "Tiempo";
                      worksheet.Cells["G1"].Value = "CaloriasQuemadas";
                      worksheet.Cells["H1"].Value = "Pasos";
                      worksheet.Cells["I1"].Value = "VelocidadPromedio";

                

                //string id = worksheet.Cells["A1"].Value.ToString();
             //   worksheet.Cells["A" + count].Value = textBox1.Text;
         /*    worksheet.Cells["B"+ count].Value = textBox1.Text;
                worksheet.Cells["C"+ count].Value = textBox2.Text;
                worksheet.Cells["D"+ count].Value = textBox3.Text;
                worksheet.Cells["E"+ count].Value = textBox4.Text;
                worksheet.Cells["F"+ count].Value = textBox5.Text;

                worksheet.Cells["G"+ count].Value = textBox7.Text;
                worksheet.Cells["H"+ count].Value = textBox8.Text;
                worksheet.Cells["I"+ count].Value = textBox9.Text;*/
                
                excel.SaveAs(excelFile);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cronometro cr = new Cronometro();
            cr.ShowDialog();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {

        }
    }
 }


