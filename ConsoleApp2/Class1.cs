using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a==b)
            {
                Console.WriteLine("{0} and {1} are equal",a,b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", a, b);
            }
            Console.ReadKey();
        }
    }
}
