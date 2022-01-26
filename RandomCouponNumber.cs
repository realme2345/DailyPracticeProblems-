using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblems
{
    class RandomCouponNumber
    {
        static int i, choice;
        static int[] arr = new int[12345];
        static int num;
        public static void findDuplicates()
        {
            while (i <= i + 1)
            {
                Console.WriteLine("Press 1 To Generate a Random Number...");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        randomNum();
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
                i++;
            }
        }
        static void randomNum()
        {
            Random random = new Random();
            num = random.Next(12345);
            arr[i] = num;
            Console.WriteLine(num);
            for (int j = 0; j < i; j++)
            {
                if (num == arr[j])
                {
                    Console.WriteLine("This Number Is Already Gnerated...");
                    break;
                }

            }

        }

    }
}

