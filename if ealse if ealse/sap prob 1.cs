﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{
    internal class sap_prob_1
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("before swaping");
            Console.WriteLine("value of a is" + a);
            Console.WriteLine("value of b is" + b);
            c = a;
            a = b;
            b = c;

            Console.WriteLine("after swapping");
            Console.WriteLine("value of a" + a);
            Console.WriteLine("value of b" + b);

        }
    }
}
