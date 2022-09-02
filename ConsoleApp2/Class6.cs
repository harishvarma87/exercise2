using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class6
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;
            if (m < 0)
            {
                n = -1;
                Console.WriteLine("the value of n is {0}", n);
            }
            else if (m > 0)
            {
                n = 1;
                Console.WriteLine("the value of n is {0}", n);
            }
            else
            {
                n = 0;
                Console.WriteLine("the value of n is {0}", n);
            }
            Console.ReadKey();
        }
    }
}
