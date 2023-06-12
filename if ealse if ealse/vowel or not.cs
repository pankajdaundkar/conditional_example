using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{
    internal class vowel_or_not
    {
        static void Main(string[] args)
        {
            //4.WAP to accept a character from user &check whether it is vowel or not

            char c;

          Console.WriteLine("entre alphabet");
           c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("it is a vowel");
            }
            else
            {
                Console.WriteLine("it is not a vowel");
            }


         
            

        }
    }
}
