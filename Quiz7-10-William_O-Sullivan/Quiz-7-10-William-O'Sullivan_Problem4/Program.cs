using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_7_10_William_O_Sullivan_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] two = {"a", "b", "c"};
            string[] three = { "d", "e", "f" };
            
            for (int i = 0; i < two.Length; i++)
            {
                for (int j = 0; j< three.Length; j++)
                {
                    Console.WriteLine(two[i] + " , " + three[j]);
                    Console.ReadLine();
                }
            }
        }
    }
}
