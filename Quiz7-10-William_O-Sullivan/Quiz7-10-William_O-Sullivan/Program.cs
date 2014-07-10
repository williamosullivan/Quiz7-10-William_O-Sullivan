using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7_10_William_O_Sullivan
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(2147483647);

            EvenOrOdd(number);
            Console.ReadLine();
        }

        private static void EvenOrOdd(int number)
        {
            Console.WriteLine(number);
            Console.ReadLine();

            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
