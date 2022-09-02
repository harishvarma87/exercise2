using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class19
    {
        public static void Main1()
        {
            Console.WriteLine("Input the height");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }
                int C = 1; 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}   ", a++);
                   
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}