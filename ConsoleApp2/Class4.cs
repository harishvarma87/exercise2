using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class4
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the year");
            int a = Convert.ToInt32(Console.ReadLine());
            if((((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0)))
            {
                Console.WriteLine("{0} is a leap year",a);
            }
            else
            {
                Console.WriteLine("{0} is not leap year",a);
            }
            Console.ReadKey();
        }
    }
}
