using System;

namespace _03_Rectangle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите ширину");
			int x;
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите высоту");
			int y;
			y = Convert.ToInt32(Console.ReadLine());
			//рисует верхнюю линию
			{
				var count = 0;
				while (count++ < x)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			//рисует боковые линии

			{
				int count1 = 2;
				while (count1++ < y)
				{
					var count = 2;
					Console.Write("*");
					while (count++ < x)
					{
						Console.Write(" ");
					}
					Console.Write("*");
					Console.WriteLine();
				}
			}
			//рисует нижнюю линию
			{
				int count = 0;
				while (count++ < x)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}