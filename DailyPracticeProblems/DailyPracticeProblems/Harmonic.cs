using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Harmonic
    {
        public static void ReadValuesFromUser()
        {
            Console.WriteLine("Calculate the harmonic series and their sum:\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Input the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            double s=0.0;
            int i;
            Console.Write("\n\n");
            for (i=1; i<=n; i++)
            {
                Console.WriteLine("1/{0}", i);
                s+=1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} \n", n, s);
        }
    }
}
