using System;
using System.Collections.Generic;
using System.Threading;

namespace _05_prg
{
	class Program
	{
		static void Main()
		{
			const int length = 10;
			var height = 5;
			var ar = InitArray(length, height);
			var ar1 = InitArray(length: length, height: height, minValue: 0, maxValue: 100);

			Show(ar);
			var arSort = Sort(ar);
			Console.WriteLine("--------------------");
			Show(arSort);
		}

		private static void Show(List<List<int>> arSort)
		{
			foreach (var item in arSort)
			{
				foreach (var i in item)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}
		}

		private static List<List<int>> Sort(int[][] ar)
		{
			var list = new List<List<int>>();
			foreach (int[] item in ar)
			{
				var ints = new List<int>(item);
				ints.Sort();
				list.Add(ints);
			}
			return list;
		}

		private static int[][] InitArray(int length, int height, int minValue = 0, int maxValue = 9)
		{
			int[][] ar = new int[height][];
			for (int i = 0; i < ar.Length; i++)
			{
				ar[i] = new int[length];
				for (int j = 0; j < length; j++)
				{
					var random = new Random();
					ar[i][j] = random.Next(minValue, maxValue);
					Thread.Sleep(5);
				}
			}
			return ar;
		}

		private static void Show(int[][] ar)
		{
			for (int i = 0; i < ar.Length; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write(ar[i][j]);
				}
				Console.WriteLine();
			}
		}
	}
}
