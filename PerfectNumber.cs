using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblems
{
    internal class PerfectNumber
    {
        public static void DispalyPerfectNumber()  // creating meyhod for a class
        {
            Console.WriteLine("Enter a number :"); // Taking the input from the user
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int x = 1; x < num; x++)
            {
                int value = (num % x);
                if (value == 0)
                {
                    Console.WriteLine("The factors {0} = {1}", num, x);
                    sum = sum + x;
                }
            }
                if (sum == num)
                {
                Console.WriteLine("{0} is a Perfect number", num);
                }
                else
                {
                    Console.WriteLine("{0} is not a Perfect number",num);
                }
            

        }
    }
}
