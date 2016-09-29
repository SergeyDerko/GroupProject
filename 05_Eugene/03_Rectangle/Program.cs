using System;

namespace _03_Rectangle
{
	class Program
	{
		static void Line(int x)
		{
			var count = 0; 
			var format = "*";
			Line(x, count, format);
			Console.WriteLine();
		}

		private static void Line(int x, int count, string str)
		{
			while (count++ < x)
			{
				Console.Write(str);
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Введите ширину");
			int x;
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите высоту");
			int y;
			y = Convert.ToInt32(Console.ReadLine());
			//рисует верхнюю линию
			Line(x);
			//рисует боковые линии

			{
				int count1 = 2;
				while (count1++ < y)
				{
					Console.Write("*");
					var count = 2;
					Line(x, count, " ");
					Console.Write("*");
					Console.WriteLine();
				}
			}
			//рисует нижнюю линию
			{
				Line(x);
			}
			Console.ReadKey();
		}
	}
}