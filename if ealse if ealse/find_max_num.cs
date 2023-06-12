using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{
    internal class find_max_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre 1st numbers");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entre 2nd number");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entre 3rd number");

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
                Console.WriteLine("c is max");
            }
        }
    }
}













        

        

