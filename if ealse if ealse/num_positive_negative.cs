using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{//5. WAP to accept a number from the user & check number is +ve or -ve or zero
    internal class num_positive_negative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre number");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("number is positive");

            }
            else if (a < 0)
            {
                Console.WriteLine("number is negative");
            }
            else if ( a == 0)
            {
                Console.WriteLine("number is equal to zero");
            }
            else
            {
                Console.WriteLine(" ");
            }   
            
        

        }
    }
}
