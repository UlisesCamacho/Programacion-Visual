using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HilosHormigas
{

    class Program
    {
        //hormiguero
        static int cargas;// <40 cargas tope
        static int espacios;// 1 por hormiga

        static int contadorHormigas;// 1 por hormiga




        static void Main(string[] args)
        {
            espacios = 5;
            cargas = 0;
            //  contadorHormigas = 0;

            Thread h1 = new Thread(Hormiga);

            Thread h2 = new Thread(Hormiga);
            Thread h3 = new Thread(Hormiga);
            Thread h4 = new Thread(Hormiga);
            Thread h5 = new Thread(Hormiga);
            Thread h6 = new Thread(Hormiga);
            Thread h7 = new Thread(Hormiga);
            Thread h8 = new Thread(Hormiga);
            Thread h9 = new Thread(Hormiga);
            Thread h10 = new Thread(Hormiga);
            Thread h11 = new Thread(Hormiga);
            Thread h12 = new Thread(Hormiga);
            Thread h13 = new Thread(Hormiga);
            Thread h14 = new Thread(Hormiga);
            Thread h15 = new Thread(Hormiga);
            Thread h16 = new Thread(Hormiga);
            Thread h17 = new Thread(Hormiga);
            Thread h18 = new Thread(Hormiga);
            Thread h19 = new Thread(Hormiga);
            Thread h20 = new Thread(Hormiga);

            // Thread reina = new Thread(reina);

            h1.Start();
            h2.Start();
            h3.Start();
            h4.Start();
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
            Console.ReadKey(true);

        }
        static void Hormiga()
        {
            int aleatorio = 0;
            while (true)
            {
                Random r = new Random();
                aleatorio = r.Next(1, 7);
                if (espacios > 0)
                {
                    espacios--;
                    Console.WriteLine("Hormiga esta buscando comida");
                    Thread.Sleep(1000);
                }

                else
                {
                    Console.WriteLine("no hay espacios para las hormigas para que puedan buscar");
                    Thread.Sleep(1000);
                }
                if (aleatorio == 6)
                {
                    cargas++;
                    Console.WriteLine("encontre comida");
                    Console.WriteLine("voy a depositar");
                    Thread.Sleep(1000);
                    espacios++;

                }
                else
                {
                    Console.WriteLine("no encontre comida");
                    Thread.Sleep(1000);
                }
            }
            if (cargas < 40)
            {


                Thread.Sleep(1000);
                Console.WriteLine("depositando");
                Console.WriteLine("El hormiguero tiene " + cargas);
                Thread.Sleep(1000);

            }
            else
            {
                Console.WriteLine("esta lleno el hormiguero");
            }


            //


            /* if (espacios > 0 && contadorHormigas == 5) 
             {
                 espacios++;
                 Console.WriteLine("Hormiga esta buscando comida");
                 Thread.Sleep(1000);
             }
             else {
                 Console.WriteLine("esperar que exista un lugar");
             }
             // lugares
             // lugar++
             // Console.WriteLine("Hormiga esta buscando comida");
             // Thread.Sleep(1000);
             if (aleatorio == 6)
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("Encontro comida");
                 Console.WriteLine("voy a cargar el hormiguero");
                 cargas++;
                 Thread.Sleep(1000);

             }
             else
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("No encontro comida");
                 Thread.Sleep(1000);
             }



             if (cargas < 40)// al reves validar primero aleatorio
             {
                 Console.WriteLine("voy a depositar en el hormiguero");
                 Console.WriteLine("depositando");
                 Console.WriteLine("El hormiguero tiene " + cargas + " carga(s) ");
                 Thread.Sleep(1000);
             }
             else
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("El hormiguero esta lleno");
                 Console.WriteLine("no se pude meter comida");
             }*/

        }
        static void reina()
        {

        }
    }
}
    

