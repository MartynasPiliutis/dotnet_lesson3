using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            char letter1;
            char letter2;
            char letter3;
            
            Console.Write("Iveskite pirma simboli: ");
            letter1 = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.Write("Iveskite antra simboli: ");
            letter2 = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.Write("Iveskite trecia simboli: ");
            letter3 = Console.ReadKey().KeyChar; ;
            Console.WriteLine("");

            Console.WriteLine("{2} {1} {0}", letter1, letter2, letter3);
            Console.ReadLine();


        }
    }
}
