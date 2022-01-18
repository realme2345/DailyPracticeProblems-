using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblems
{
    // program is to find the remainder and quotient
    internal class QuotientAndRemainder
    {
        public static void DispalyRemainder(int a,int b) //  the parameters 
        {
            int dividend = a; // intialising the parameter values
            int divisor = b;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
