using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1判斷某樹是不是質數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入一個數字");
			string input = Console.ReadLine();
			int number = Convert.ToInt32(input);
			int space = 0;

			for (int i = 1; i <= number ; i++)
			{
				if (number % i == 0)
				{
					space = space + 1 ;
				}
				
			}
			if (space == 2)
			{
				Console.WriteLine("質數");
			}
			else
			{
				Console.WriteLine("非質數");
			}

		}
	}
}
