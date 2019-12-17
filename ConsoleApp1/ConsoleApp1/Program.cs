using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human
    {
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Example1
            float skaiciusFloat = 1f / 3;
            double skaiciusDouble = 1d / 3;

            if (skaiciusFloat == skaiciusDouble)
            {
                Console.WriteLine("skaiciusFloat {0} YRA skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            else
            {
                Console.WriteLine("skaiciusFloat {0} NERA skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            Console.ReadLine();

            //Example2

            decimal skaicius1 = 0.1m * 10;
            decimal skaicius2 = 0m;

            for (int ctr = 0; ctr < 10; ctr++)
            {
                skaicius2 += 0.1m;
            }

            Console.WriteLine("{0} = {1} : {2}", skaicius1, skaicius2, skaicius1 == skaicius2);
            Console.ReadLine();

            //Example3
            Human human1 = new Human();
            human1.Name = "Batman";

            Human human2 = human1;

            Console.WriteLine("human1.Name: " + human1.Name);
            Console.WriteLine("human2.Name: " + human2.Name);

            human1.Name = "Joker";
            Console.WriteLine("human1.Name: " + human1.Name);
            Console.WriteLine("human2.Name: " + human2.Name);

            Console.ReadLine();
        }
    }
}
