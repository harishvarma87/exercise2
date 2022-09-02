using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class13
    {
        public static void Main1()
        {
            Console.WriteLine("Input the number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("{0}x{1}={2} ", j, i, j * i);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
