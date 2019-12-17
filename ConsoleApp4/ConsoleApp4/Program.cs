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
            /*//Example1
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

            Console.ReadLine();*/

            //Task1

            int grupesSkaicius;
            int salyga = 0;

            Console.Write("Iveskite grupes nariu skaiciu: ");
            grupesSkaicius = 0;

            if (!int.TryParse(Console.ReadLine(), out grupesSkaicius))
            {
                Console.WriteLine("Ivesta neteisinga reiksme");
                Console.WriteLine("Spauskite [ENTER]");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (grupesSkaicius == 1)
            {
                salyga = 1;
            }
            else if (grupesSkaicius == 2)
            {
                salyga = 2;
            }
            else if (grupesSkaicius > 2 && grupesSkaicius <= 10)
            {
                salyga = 3;
            }
            else if (grupesSkaicius > 10)
            {
                salyga = 4;
            }
            else
            {
                Console.WriteLine("Ivesta neteisinga reiksme");
                Console.WriteLine("Spauskite [ENTER]");
                Console.ReadLine();
                Environment.Exit(0);
            }
            switch (salyga)
            {
                case 1:
                    Console.WriteLine("Tai solistas");
                    break;
                case 2:
                    Console.WriteLine("Tai duetas");
                    break;
                case 3:
                    Console.WriteLine("Tai ansamblis");
                    break;
                case 4:
                    Console.WriteLine("Tai orkestras");
                    break;
            }
            Console.WriteLine("Spauskite [ENTER]");
            Console.ReadLine();
        }
    }
}
