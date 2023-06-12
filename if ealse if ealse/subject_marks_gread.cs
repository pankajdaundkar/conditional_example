using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if_else
{
    internal class subject_marks_gread
    {//3.Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
      // Display grade as below.
//        Percentage > 80% - Grade A
//Percentage > 70% - Grade B
//Percentage > 60% - Grade C
//Percentage< 60% - Grade D

        static void Main(string[] args)
        {
        Console.WriteLine("marks in physics");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("marks in chemistry");
         int chem = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("marks in maths");
          int maths = Convert.ToInt32(Console.ReadLine());
            
            int total = ( physics + chem + maths );
            Console.WriteLine("total is " + total);
            double percentage = ((double) total / 300 * 100);

            Console.WriteLine(" percentage is "+ percentage);

            string grade;

            if (percentage > 80)

            {
                grade = " A ";
            }
            else if (percentage > 70)
            {
                grade = "B";
            }
            else if (percentage > 60)
            {
                grade = "C";
            }
            else 
            {
                grade = "D";
            }

            Console.WriteLine("grade = " + grade);








        }
    }
}
