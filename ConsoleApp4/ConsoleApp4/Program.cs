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
            //Example1
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

            //Example2 - kaip daryti nereiketu

            Console.Write("Iveskite spalva: ");
            string spalva = Console.ReadLine();

            if ((spalva == "geltona")||(spalva=="zalia")||(spalva=="raudona"))
                Console.WriteLine("{0} - tai yra trispalves spalva", spalva);
            else
                Console.WriteLine("{0} - nera trispalves spalva", spalva);

            Console.ReadLine();

        }
    }
}
