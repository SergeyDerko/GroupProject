using System;
using System.Threading;

namespace _05_Anime
{
	class Program
	{
		static void Main()
		{
			for (int i = 0, j = Console.WindowWidth; i < Console.WindowWidth; i++, j--)
			{
				for (int k = 0; k < i; k++)
				{
					Console.Write(" ");
				}
				Console.Write("**");
				Console.WriteLine();
				for (int k = 0; k < i; k++)
				{
					Console.Write(" ");
				}
				Console.Write("**");
				Thread.Sleep(100);
				Console.Clear();
			}
			Console.ReadKey();
		}
	}
}
