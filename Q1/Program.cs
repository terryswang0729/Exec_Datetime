using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime dvdReturnDate = today.AddDays(3);
		    string value=dvdReturnDate.ToString("yyyy/MM/dd");
			Console.WriteLine($"dvd歸還時間:{value}");
		}
	}
}
