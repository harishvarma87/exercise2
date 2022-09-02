using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class10
    {
        public static void Main1()
        {
            Console.WriteLine("Input the marks obtained in Physics");
            int p= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Maths");
            int m = Convert.ToInt32(Console.ReadLine());
            if(p>=55 && c>=50 && m>=65)
            {
                if(p+c+m>=180 || p+m>=140)
                    Console.WriteLine("The candidate is eligible for admission");
                else
                    Console.WriteLine("The candidate is not eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadKey();
        }
    }
}
