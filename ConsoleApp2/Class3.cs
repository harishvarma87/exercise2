using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class3
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a<0)
            {
                Console.WriteLine("{0} is negative", a);
            }
            else if(a>0)
            {
                Console.WriteLine("{0} is positive", a);
            }
            else
            {
                Console.WriteLine("{0} is zero", a);
            }
            Console.ReadKey();
        }
    }
}
