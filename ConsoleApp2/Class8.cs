using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class8
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
            Console.ReadKey();
        }
    }
}
