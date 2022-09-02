using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class20
    {
        public static void Main()
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
  
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*   ");

                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
