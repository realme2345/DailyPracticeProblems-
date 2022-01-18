using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblems
{
    internal class Largest
    {
        public static void DisplayLargest() //creating method for a class
        {
            Console.WriteLine("Enter a first number :"); // Taking the input from the user
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number :"); // Taking the input from the user
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number :"); // Taking the input from the user
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3) // if num1 is greater then it print num1 is greater 
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}
