using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblems
{/// <summary>
/// Vending Machine
/// </summary>
     class VendingMachine
     {
	    // Static Variables i for indexing the array and total for calculating the total Notes
		static int total = 0;
		static int i;
		static int rem;
		int money;
		// Function for Calculating the notes
		public static void calculate(int money, int[] notes)  //calling calculate Function
		{
			if (money == 0)
			{
				Console.WriteLine("please Enter Valid amount");
			}
			else
			{
				if (money >= notes[i])// logic for Calculating The notes
				{
					int calNotes = money / notes[i];
					rem = money % notes[i];
					money = rem;
					total += calNotes;
					Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
				}
				Console.WriteLine("Remaining Money={0}", money);
				Console.WriteLine("Total Number of Notes are:{0}", total);
			}
		}//End program
	   
     }
}
