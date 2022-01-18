using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblems
{
    internal class Factors  //C# Program to Display the Factors of the Entered Number
    {
        public static void DispalyFactors()  // creating meyhod for a class
        {
            Console.WriteLine("Enter a number :"); // Taking the input from the user
            int num = Convert.ToInt32(Console.ReadLine());
            for (int x = 2; x < num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine("The factors {0} = {1}", num, x);
                }
                
            }
            
        }
    }
}
