using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\u0056\u00E4\u00D6");
            Console.WriteLine("\"hello world\"");
            string x = "Hello World";
            string y = x.ToUpper();
            Console.WriteLine(y);
            string z = x.ToLower();
            Console.WriteLine(z);
            Console.WriteLine(x.Length);

            Console.ReadKey();
        }
    }
}
