using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class14
    {
        public static void Main1()
        {
            Console.WriteLine("Input the number of terms");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 1;
            Console.Write("The odd numbers are:");
            int sum = 0;
            while (count < a)
            {
                Console.Write("{0} ",i);
                sum += i;
                i += 2;
                count += 1;
            }
            Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1}",a,sum);
            Console.ReadKey();
        }
    }
}
