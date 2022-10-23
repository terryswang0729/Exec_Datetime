using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int todayTime=DateTime.Now.Hour;
			string result=string.Empty;
			
			if (todayTime >14) 
			{
				result = "晚安";
			}
			else if(todayTime>11&&todayTime<=14)
			{
				result = "午安";
			}
			else
			{
				result = "早安";
			}
			Console.WriteLine(result);
		}
	}
}
