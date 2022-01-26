using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblems
{/// <summary>
/// Temaparature conversation
/// </summary>
    class TemparatureConversation
    {
        public static void DispalyTemaparature() //Creating a static method
        {
            double fahrenheit, celsius;
            Console.WriteLine(" To convert Fahrenheit to celsius ");
            Console.WriteLine("Enter a temparature Fahrenheit:");
            double f= Convert.ToDouble(Console.ReadLine());
            celsius = (f - 32)*5/9;
            Console.WriteLine("celsius temaparature :" + celsius);
            Console.WriteLine("To convert celsius to Fahrenheit :");
            Console.WriteLine(" Enter a temparature  celcious :");
            double c= Convert.ToDouble(Console.ReadLine());
            fahrenheit = (c * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit temparature :" + fahrenheit);
        }
    }
}
