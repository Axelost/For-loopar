using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning 1
            /*
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            
            //övning2

            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            
            //övning 3

            for (int i = 0; i < 51; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            
            //övning 4

            Console.Write("mata in start: ");
            int start= int.Parse( Console.ReadLine());
            Console.Write("mata in stop: ");
            int stop = int.Parse(Console.ReadLine());
            Console.Write("mata in steg: ");
            int steg = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = start; i <= stop; i+=steg)
            {
                Console.Write(i + " ");
            }
            
            //övning 5
            Console.Write("mata in ett heltal: ");
            int max = int.Parse(Console.ReadLine());
            int summa= 0;
            for (int i = 0; i <= max ; i++)
            {
                
                summa += i;

                if (i == max)
                {
                    Console.WriteLine(summa);
                }

            }
            
            //övning 6
            Console.Write("Mata in ett heltal");
            int heltal = int.Parse(Console.ReadLine());
            if (heltal < 21)
            {
                Console.WriteLine("nope");
            }
            else
            {
                for (int i = 0; i <= heltal; i++)
                {

                    if (i % 7 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            //övning 7
            Console.Write("mata in ett heltal:");
            int max = int.Parse( Console.ReadLine());
            int fib = 1;
            int fib2 = 0;
            if (max == 0)
                Console.WriteLine("fibotalet blir 0");
            else if (max == 1) 
                Console.WriteLine("fibotalet blir 1");
            else
                for (int i = 1; i <= max; i++)
                {
                    
                    Console.WriteLine(fib );
                    fib += fib2 ;
                    fib2 = fib - fib2;

                }
                 */
            //övning 8
            Console.Write("mata in ett heltal:");
            int tal = int.Parse(Console.ReadLine());
           
                for (double i = 0;  i < tal; i+=0.1)
                {
                
                 

                if (i*i*i >= tal)
                {
                    Console.WriteLine(Math.Round( i,1));
                    i = tal + 1;
                    

                }

                }
            Console.ReadKey();
            }

           
            
            
        }
    }

