using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeProblems
{
    internal class Alphabet // program to alphabet is vowel or consonant
    {
        public static void Dispalyalphabet() // creating method for class
        {
            Console.Write("\n\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            
                switch (ch) // switch case check the vowels
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is  a consonant");
                        break;
                }
            
        }
    }
}
