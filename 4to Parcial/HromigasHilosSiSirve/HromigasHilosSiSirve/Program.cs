using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HromigasHilosSiSirve
{

    class Program
    {
        static int espacios;
        static int unidades;
        static void Main(string[] args)
        {
            espacios = 5;
            unidades = 0;
            Thread h1 = new Thread(hormiga);
            Thread h2 = new Thread(hormiga);
            Thread h3 = new Thread(hormiga);
            Thread h4 = new Thread(hormiga);
            Thread h5 = new Thread(hormiga);
            Thread h6 = new Thread(hormiga);
            Thread h7 = new Thread(hormiga);
            Thread h8 = new Thread(hormiga);
            Thread h9 = new Thread(hormiga);
            Thread h10 = new Thread(hormiga);
            Thread h11 = new Thread(hormiga);
            Thread h12 = new Thread(hormiga);
            Thread h13 = new Thread(hormiga);
            Thread h14 = new Thread(hormiga);
            Thread h15 = new Thread(hormiga);
            Thread h16 = new Thread(hormiga);
            Thread h17 = new Thread(hormiga);
            Thread h18 = new Thread(hormiga);
            Thread h19 = new Thread(hormiga);
            Thread h20 = new Thread(hormiga);
            Thread r = new Thread(reina);
            h1.Start();
            h2.Start();
            h3.Start();
            h5.Start();
            h6.Start();
            h7.Start();
            h8.Start();
            h9.Start();
            h10.Start();
            h11.Start();
            h12.Start();
            h13.Start();
            h14.Start();
            h15.Start();
            h16.Start();
            h17.Start();
            h18.Start();
            h19.Start();
            h20.Start();
            r.Start();

        }

        static void hormiga()
        {
            while (true)
            {
                int aleatorio = 0;
                Random r = new Random();
                aleatorio = r.Next(1, 7);
                if (espacios > 0)
                {
                    espacios--;
                    Console.WriteLine("buscando comida");
                    Thread.Sleep(800);
                    espacios++;
                }
                else
                {
                    Console.WriteLine("no hay espacio para buscar comida");
                    Thread.Sleep(800);
                }

                if (aleatorio == 6)
                {
                    unidades++;
                    Console.WriteLine("encontre comida");
                    Console.WriteLine("voy a depositar");
                    Thread.Sleep(800);

                }
                else
                {
                    Console.WriteLine("no encontre comida seguire buscando");
                    Thread.Sleep(800);
                }
                if (unidades < 40)
                {
                    Console.WriteLine("depositando");
                    Console.WriteLine("el hormiguero tiene " + unidades);
                    Thread.Sleep(500);

                }
                else
                {
                    Console.WriteLine("el hormiguero esta lleno");
                }
            }
        }
        static void reina()
        {
            int hambre;
            int aux;
            while (true)
            {
                hambre = 25;
                Console.WriteLine("Hormiga reina pasara por el hormiguero");
                Thread.Sleep(5000);
                Console.WriteLine("Hormiga Reina: Tengo hambre");
                if (unidades >= 25)
                {
                    unidades -= 25;
                    Console.WriteLine("Hormiga Reina Comiendo");
                    Thread.Sleep(5000);
                }
                else
                {
                    while (hambre > 0)
                    {
                        aux = hambre;
                        if (aux <= unidades)
                        {
                            unidades -= aux;
                            hambre = 0;
                        }
                        else
                        {
                            hambre -= unidades;
                            unidades = 0;
                        }

                        Console.WriteLine("Hormiga Reina Comiendo");
                        Console.WriteLine("Hormiga Reina : aun tengo hambre");
                        Thread.Sleep(2000);
                    }
                }
            }
        }
    }
}

