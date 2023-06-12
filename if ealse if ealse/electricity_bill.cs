using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_ealse_if_ealse
{
    internal class electricity_bill
    {
        static void Main(string[] args)
        {int unit = 160;
double amount, total, charge;

if (unit <= 50)
{
    amount = unit * 0.50;
}
else if (unit <= 250) 
{
    amount = 100 + (unit - 150) * 1.20;
}
else
{
    amount = 220 + (unit - 250) * 1.50;
}

charge = amount * 0.20;
total = amount + charge;

Console.WriteLine("Electricity Bili is = " + total);

            
           
            

            
        
              
            
        }
    
    }
}
