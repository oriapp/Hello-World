using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(50);
			var name = "class";
			Console.WriteLine($"Hello {name.ToUpper()}!");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("I'm here!");
			System.Threading.Thread.Sleep(399);
			Console.WriteLine(" /: ");

        }
    }
}
