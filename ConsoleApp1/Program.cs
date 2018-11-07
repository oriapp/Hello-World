using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 1;

			int i = 2;
			while (x < 10)
			{
				//Or i <= i * 2;
				Console.WriteLine(x);
				x++;
				i = i * 2;
			}
			Console.WriteLine("How namy times?");
		}
	}
}
