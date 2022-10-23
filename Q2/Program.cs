
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime bookReturnDate = today.AddMonths(1);
			string value = bookReturnDate.ToString("yyyy/MM/dd");
			Console.WriteLine($"圖書歸還時間:{value}");
		}
	}
}
