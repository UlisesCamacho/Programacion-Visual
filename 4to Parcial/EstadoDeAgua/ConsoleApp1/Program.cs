using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(Agua);
            Thread t2 = new Thread(Agua);
            t.Name = "hilo1";
            t2.Name = "hilo2";

            t.Start();  //Nos permite iniciar un hilo
            t2.Start();  //Nos permite iniciar un hilo

            Console.Read();
        }


        public static void Agua()
        {
         //   int estado = 0;
            while(true)
            { 
            Console.WriteLine("estoy solido");
            Thread.Sleep(5000);
            Console.WriteLine("Me derrito");
            Console.WriteLine("Estoy liquido");
            Thread.Sleep(5000);
            Console.WriteLine("Me Evaporo");
            Console.WriteLine("Estoy gaseoso");
            }

            //5 segundos solido
            //Derrite
            //5 Segundos Liquido
            //Evapora
            //5 segundos gaseoso


            //0 solido
            //1 liquido
            //2 gaseoso


        }
    }
}
