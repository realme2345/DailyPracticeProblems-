using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblems
{
    class SquareRoot
    {
        // Function to return the square root of
        // a number using Newtons method
        public static  double DispalySquareRoot(double n, double l)
        {
            double x = n;
            double root;
            int count = 0;
            while (true)
            {
                count++;
                root = 0.5 * (x + (n / x));// calculate square root for non negative value
                if (Math.Abs(root - x) < l)
                   break;
                x = root;
            }
            return root;
        }
    }
}

