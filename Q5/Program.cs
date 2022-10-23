using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
		  Console.Write("請輸入今年年份:");
	      string input=Console.ReadLine();

		  int year = Convert.ToInt32(input);
		  DateTime firstDay = new DateTime(year, 1, 1);

		  int weekday=(int)firstDay.DayOfWeek;
		  DateTime firstSunday=firstDay.AddDays((7-weekday)%7);

		  DateTime endDay=new DateTime(year, 12, 31);

			for (DateTime i = firstSunday; i <=endDay; i=i.AddDays(7))
			{
				Console.WriteLine(i.ToString("yyyy/MM/dd"));
			}
		}
	}
}
