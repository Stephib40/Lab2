using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;

			Console.WriteLine("Please enter a number between 1 and 100");
			i = int.Parse(Console.ReadLine());
			int h = i % 2;
			bool numOdd = true; 
				
			if (h % 2 == 0)
			{
				Console.WriteLine("Your number is an even number.");
			}
			else 
			{
				Console.WriteLine("Your number is an odd number.");
			}
			if (numOdd == true)//i cant get the bool and the if statement to not contradict 
			{
				Console.WriteLine("your number is odd");
			}
			else
			{
				Console.WriteLine("your number is even");
			}
			
			//shouldnt I have a switch statement in here?
			//well I bombed this lab. 
		}



		

	}
}
