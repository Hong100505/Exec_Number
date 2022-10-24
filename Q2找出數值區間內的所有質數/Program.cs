using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2找出數值區間內的所有質數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("輸入，1要到哪個數字之間的質數");
			string input = Console.ReadLine();
			int number = Convert.ToInt32(input);
			

			for (int i =2 ; i <= number; i++)   //2~某數
			{

				for (int k = 2; k <= i; k++)
				{
					if (i % k == 0 && i != k)
					{
						break;
					}
					if (i % k ==0 && i == k)
					{
						Console.WriteLine(i);
					}

				}
			}
			
			

		}
	}
}
