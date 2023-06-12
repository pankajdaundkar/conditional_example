using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{//7.    Write a C# program to input any character and check whether it is alphabet, digit or special character 
    internal class find_alphabet_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre any character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >='a' && ch <= 'z')
            {
                Console.WriteLine("it is an alphabet");
            }
            else if (ch >='0' && ch <= '9')
            {
                Console.WriteLine("it is digit");
            }
            else
            {
                Console.WriteLine("its a special character");
            }
            
           
        }
    }
}
