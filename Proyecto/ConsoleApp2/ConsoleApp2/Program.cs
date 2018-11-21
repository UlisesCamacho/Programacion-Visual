using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Panal
       static int espacios;
       static int unidades;

        static void Main(string[] args)
        {
            espacios = 5;
            unidades = 0;
            Thread t1 = new Thread(abeja);
            Thread t2 = new Thread(abeja);
            Thread t3 = new Thread(abeja);
            Thread t4 = new Thread(abeja);
            Thread t5 = new Thread(abeja);
            Thread t6 = new Thread(abeja);
            Thread t7 = new Thread(abeja);
            Thread t8 = new Thread(abeja);
            Thread t9 = new Thread(abeja);
            Thread t10 = new Thread(abeja);

            Thread o = new Thread(oso);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();
            o.Start();
            
        }


        static void abeja()
        {
            while(true)
            { 
                //Produciendo
                Console.WriteLine("Estoy produciendo");
                Thread.Sleep(3000);
                Console.WriteLine("Voy a depositar");
                if (espacios > 0 && unidades < 30)
                {
                    espacios--;
                    unidades++;
                    Console.WriteLine("Depositando");
                    Thread.Sleep(1000);
                    espacios++;
                }
                

            }

        }

        static void oso()
        {
            int hambre;
            int aux;
            while(true)
            {
                hambre = 20;
                Console.WriteLine("ZZZZZZ");
                Thread.Sleep(4000);
                Console.WriteLine("Tengo hambre");
                if (unidades >= 20)
                {
                    unidades -= 20;
                    Console.WriteLine("Comiendo");
                    Thread.Sleep(3000);
                }
                else
                {
                    while (hambre>0)
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
                        
                        Console.WriteLine("Comiendo");
                        Console.WriteLine("aun tengo hambre");
                        Thread.Sleep(500);
                    }
                }
            }
        }
    }
}
