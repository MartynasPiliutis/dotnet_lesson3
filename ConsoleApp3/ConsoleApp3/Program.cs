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

            //Task2

            double atstumas;
            double laikas;
            double greitis;

            Console.Write("Iveskite atstuma metrais: ");
            atstumas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite laika sekundemis: ");
            laikas = Convert.ToDouble(Console.ReadLine());

            greitis = atstumas / laikas * 3.6;

            Console.WriteLine("Jusu greitis yra {0} km/h", greitis);
            Console.ReadLine();

            //Task3

            double r;
            double plotas;
            double turis;

            Console.Write("Iveskite rutulio skersmeni: ");
            r = Convert.ToDouble(Console.ReadLine()) / 2;

            plotas = Math.PI * r * r;
            turis = 3 * Math.PI / 4 * r * r * r;

            Console.WriteLine("Plotas: {0}", plotas);
            Console.WriteLine("turis: {0}", turis);
            Console.ReadLine();
        }
    }
}
