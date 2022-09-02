using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class17
    {
        public static void Main1()
        {
            Console.WriteLine("Input the height");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
