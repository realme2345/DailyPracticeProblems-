using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblems
{
    internal class EvenOrAdd
    {
        public static void DisplayEvenOrAdd()
        {
            Console.WriteLine("Enter a number :"); // Taking the input from the user
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("It is {0} Even number", i);
                }
                else
                {
                    Console.WriteLine("It is {0} Odd number", i);
                }
            }
        }
    }
}
