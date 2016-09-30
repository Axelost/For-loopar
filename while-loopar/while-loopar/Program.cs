using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning 1
            /*
            int a = 1;
            while (a<101)
            {
                Console.WriteLine(a);
                a++;
               
            }

            //övning 2
            Console.Write("Skriv in ditt lösenord:");
            bool x = true;
            while (x)
            {
            string Password = Console.ReadLine();
                if (Password == "hej")
                {
                    Console.WriteLine("wp");
                    x = false;

                }
                else
                {
                    Console.WriteLine("du suger");
                }
            }
            
            //övning 2.1
            int i = 1;
            while (i<101)
            {
                Console.WriteLine(i);
                i++;

            }
            
            //övning 2.2
            int i = 10;
            while (i>0)
            {
                Console.WriteLine(i);
                i--;

            }
            
            //övning 2.3
            while (true)
                Console.WriteLine("dumt");
            {

            }
            
            //övning 2.4
            Console.WriteLine("gissa på ett tal mellan 1 och 100");
            Random rng = new Random();
            bool x = true;
            int tal = rng.Next(100);
            int i = 0;
            while (x)
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess<tal)
                {
                    Console.WriteLine("För lågt");
                }
                else if (guess>tal)
                {
                    Console.WriteLine("För högt");

                }
                else
                {
                    Console.WriteLine("Grattis! Det tog " + i + " försök");
                    x = false;
                }
                i++;
            }
            
            //övning 2.5
            
            
            int fib = 1;
            int fib2 = 0;
            
           
                while( fib < 1000000)
                {

                    Console.Write(fib + " ");
                    fib += fib2;
                    fib2 = fib - fib2;
                
                }
                */
            //övning 2.6
            Console.Write("mata in ditt saldo:");
            double saldo = double.Parse( Console.ReadLine());
            Console.Write("ange räntan:");
            double rent = double.Parse(Console.ReadLine());
            Console.Write("ange mål:");
            int goal = int.Parse(Console.ReadLine());
            var tru = true;
            var i = 1;
            while (tru)
            {
                saldo = saldo * ((rent / 100) + 1);
                if (saldo >= goal) 
                {
                    tru = false;
                    Console.WriteLine("det tog " + i + " år innan saldot nådde " + saldo);

                }
                i++;

            }


            Console.ReadLine();

        }
    }
}
