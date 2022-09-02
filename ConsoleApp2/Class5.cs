using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class5
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote"); 
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote");
            }
            Console.ReadKey();
        }
    }
}
