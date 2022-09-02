using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class12
    {
        public static void Main1()
        {
            Console.WriteLine("Input the number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", a, i, a * i);
            }
            Console.ReadKey();
        }
    }
}
