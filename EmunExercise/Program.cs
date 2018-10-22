using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmunExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the current day of the week.");
			string userDay = Console.ReadLine();
			DaysOfTheWeek day;

			try
			{
				day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
				Console.WriteLine(day);

			}
			catch (Exception ex)
			{
				Console.WriteLine("Please enter a valid weekday.");
				Console.WriteLine(ex.Message);
				Console.ReadLine();
				
			}
			

			Console.ReadLine();




		}
		enum DaysOfTheWeek
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
	}
}
