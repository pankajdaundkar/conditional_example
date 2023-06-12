using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{
    internal class swap_witout_var
    {
        static void Main(string[] args)

        {//2.Swap values of two integer variables without using third variable.


            int a = 20;
            int b = 15;

            Console.WriteLine(" before swap");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swap");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }


        }
}
