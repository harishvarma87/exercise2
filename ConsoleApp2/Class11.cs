using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class11
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {0} is :{1}",i,i*i*i);
            }
            Console.ReadKey();
        }
    }
}
