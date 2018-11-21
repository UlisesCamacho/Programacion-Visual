using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos
{
    public partial class Form1 : Form
    {
        List<Figura> lf;

        public Form1()
        {
            InitializeComponent();
            lf = new List<Figura>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Figura f in lf)
            {

                switch (f.dir)
                {
                    case 1:

                        if (f.x <= ClientRectangle.Width - 25)
                        {
                            f.x += 10;
                        }
                        else
                        {
                            f.dir = 2;
                        }
                        if (f.y <= ClientRectangle.Bottom - 20)
                        {
                            f.y += 10;
                        }
                        else
                        {
                            f.dir = 4;
                        }
                        break;
                    case 2:
                        if (f.x >= 0)
                        {
                            f.x -= 10;
                        }
                        else
                        {
                            f.dir = 1;
                        }
                        if (f.y <= ClientRectangle.Bottom - 20)
                        {
                            f.y += 10;
                        }
                        else
                        {
                            f.dir = 3;
                        }
                        break;
                    case 3:
                        if (f.x >= 0)
                        {
                            f.x -= 10;
                        }
                        else
                        {
                            f.dir = 4;
                        }
                        if (f.y >= ClientRectangle.Top + 10)
                        {
                            f.y -= 10;
                        }
                        else
                        {
                            f.dir = 2;
                        }
                        break;
                    case 4:
                        if (f.x <= ClientRectangle.Right - 25)
                        {
                            f.x += 10;
                        }
                        else
                        {
                            f.dir = 3;
                        }
                        if (f.y >= ClientRectangle.Top + 10)
                        {
                            f.y -= 10;
                        }
                        else
                        {
                            f.dir = 1;
                        }
                        break;
                }
                Invalidate(); //figura rebote entre ella
                foreach (Figura aux in lf)
                {
                    if (f != aux)
                    {
                        if ((aux.x >= f.x - 10 && aux.x <= f.x + 10)&& (aux.y >= f.y - 20 && aux.y <= f.y + 20))
                        {

                            aux.dir = 2;
                            f.dir = 4;
                        }
                    }
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Figura f = new Figura();
            Random ra = new Random(10);
          


            f.x = e.X;
            f.y = e.Y;
            switch (ra.Next(10))
            {
                case 1:
                    f.dir = 1;
                    break;
                case 2:
                    f.dir = 2;
                    break;
                case 3:
                    f.dir = 3;
                    break;
                case 4:
                    f.dir = 4;
                    break;
            }


                    lf.Add(f);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
          
            Random r = new Random(6);
           
            foreach (Figura f in lf)
            {

                switch (r.Next(6))
                {
                    case 1:
                        SolidBrush sb2 = new SolidBrush(Color.Red);
                        g.FillEllipse(sb2, f.x, f.y, 20, 20);
                        break;
                    case 2:
                        SolidBrush sb3 = new SolidBrush(Color.Yellow);
                        g.FillEllipse(sb3, f.x, f.y, 20, 20);
                        break;
                    case 3:
                        SolidBrush sb4 = new SolidBrush(Color.Green);
                        g.FillEllipse(sb4, f.x, f.y, 20, 20);
                        break;
                    case 4:
                        SolidBrush sb5 = new SolidBrush(Color.Blue);
                        g.FillEllipse(sb5, f.x, f.y, 20, 20);
                        break;
                    case 5:
                        SolidBrush sb7 = new SolidBrush(Color.Purple);
                        g.FillEllipse(sb7, f.x, f.y, 20, 20);
                        break;

                    default:
                   SolidBrush sb6 = new SolidBrush(Color.Black);
                        g.FillEllipse(sb6, f.x, f.y, 20, 20);
                        break;
                }
            }
        }
    }
}
