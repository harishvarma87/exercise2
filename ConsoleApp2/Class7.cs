using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class7
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the height");
            int h = Convert.ToInt32(Console.ReadLine());
            if(h<=150)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else if(h>150 && h<170)
            {
                Console.WriteLine("The person is of average height");
            }
            else
            {
                Console.WriteLine("The person is of normal");
            }
            Console.ReadKey();
        }
    }
}
