using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite grupes pavadinima: ");
            string grupesPavadinimas = Console.ReadLine();

            Console.Write("Iveskite nariu skaiciu: ");
            int nariuSkaicius = 0;

            if (!int.TryParse(Console.ReadLine(), out nariuSkaicius))
            {
                Console.WriteLine("Ivesta neteisinga reiksme: Nariu skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Grupes pavadinimas: {0}", grupesPavadinimas);
            Console.WriteLine("Grupes nariu skaicius: {0}", nariuSkaicius);
            Console.ReadLine();
                

        }
    }
}
