using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{//6. Write a C# program to find maximum between three numbers (using logical operator)
    internal class num_is_max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("a is max");
            }
            else if (b > c)
            {
                Console.WriteLine("b is max");
            }
            else
            {
                Console.WriteLine("c is max");

            }
        }
    }
}
