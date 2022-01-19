using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblems
{
    internal class PowerOfTwo //C# Program to Display the power of tw0 of the Entered Number
    {
        public void DispalyPowerOfTwo() // creating method for clss
        {
            Console.WriteLine("Enter a number :"); // Taking the input from user
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                double Sqr = Math.Pow(2, num);
                Console .WriteLine("2^{0}={1}", num,Sqr);
                break;
            }
        }
    }
}
