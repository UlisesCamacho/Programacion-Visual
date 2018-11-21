using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ExamenTitulo1
{
    public partial class Form1 : Form
    {
        public int vidas = 3;
        public const int Aux = 500;
        public const int Aux1 = 10;
        public const int Aux2 = 10;
        public const int Limite = 50;
        // bool band = true, band1 = true;


        Rectangle Bola = new Rectangle(165, 212, 15, 15);
        Rectangle rect = new Rectangle(0, 0, 0, 0);
        List<Rectangle> Lista = new List<Rectangle>();
        static Timer tiempo = new Timer();
        int yVel = 1;
        int xVel = 1;


        public Form1()
        {
            this.Width = Aux;

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

            tiempo.Tick += new EventHandler(timer1_Tick);
            tiempo.Interval = 5;
            tiempo.Start();
            DoubleBuffered = true;
        }



        void Bolla(Brush b, Pen p, PaintEventArgs e)
        {

            int x = 0, y = 200, count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    b = new SolidBrush(Color.Yellow);

                    Rectangle temp = new Rectangle(5, 5, Limite, 8);
                    Lista.Add(temp);
                    x += (Limite + 2);
                  //  e.Graphics.DrawRectangle(p, Lista[count]);
                    //e.Graphics.FillRectangle(b, Lista[count]);
                    count++;
                    
                }





            }

        }
        public void GameBall(Brush b, Pen p, PaintEventArgs e)
        {

            e.Graphics.DrawEllipse(p, Bola);
            e.Graphics.FillEllipse(b, Bola);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Blue, 1.0f);
            Brush b = new SolidBrush(Color.Black);

            GameBall(b, p, e);
            //Bolla2(b, p, e);
            Bolla(b, p, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            /*  if (((Bola.Y + Bola.Height) / 2) <= this.ClientSize.Height)
                  band = true;
              else
                  band = false;
              if (((Bola.X + Bola.Width) / 2) <= this.ClientSize.Width)

                  band1 = true;
              else
                  band1 = false;*/
            //   if (band == false)
            // {
            if (Bola.Y == 0)
                yVel = 1;
            if (Bola.X + Bola.Width == this.ClientSize.Width)
                xVel = -xVel;
            if (Bola.X == 0)
                xVel = -xVel;
            if (Bola.Y + Bola.Width == this.ClientSize.Height)
            {
                yVel = +yVel;
                timer1.Stop();
                MessageBox.Show("Enserio?" + " tan malo eres!  " + label1.Text);
                Invalidate();
                
            }


            //}
            // else
            xVel = +xVel;
            
            for (int i = 0; i < 15; i++)
            {
                // if (band1 == false)
                //{
                if (pictureBox1.Bounds.IntersectsWith(Bola))
                {

                    Lista.Insert(i, rect);
                    yVel = -yVel;


                }
                
               // st.Show();
                
                vidas = vidas - 1;
                Lista.RemoveAt(i);
                //  }
                //else
                yVel = +yVel;
                 

            }
            
            
            Bola.Location = new Point(Bola.X + xVel, Bola.Y + yVel);
            Invalidate();
            






        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.X > 0 & e.X < this.Width - 72) Bola.Location = new Point(e.X, Bola.Y);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Right)
            {
                if (pictureBox1.Location.X <= 324)
                {
                    pictureBox1.Left += 20;
                }
            }
            if (e.KeyData == Keys.Right)
            {
                if (pictureBox1.Location.X <= 324)
                {
                    pictureBox1.Left += 20;
                }
            }

            if (e.KeyData == Keys.Left)
            {
                if (pictureBox1.Location.X > 0)
                {
                    pictureBox1.Left -= 20;
                }
            }

          

            


            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
             
        }
        }

        
    }
