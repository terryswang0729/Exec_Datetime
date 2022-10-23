using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int day=DateTime.Today.Day;
			string result=string.Empty;	
			if(day>20)
			{
				result = "下旬";
			}
			else if(day>10)
			{
				result = "中旬";
			}
			else
			{
				result = "下旬";
			}
			Console.WriteLine($"今天是本月的{result}");
		
		}
	}
}
