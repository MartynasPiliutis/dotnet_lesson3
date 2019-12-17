using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example4

            double x = 1234.7;
            int a;

            //a = x; neveiks konvertavimas
            a = (int)x;

            Console.WriteLine(x);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
