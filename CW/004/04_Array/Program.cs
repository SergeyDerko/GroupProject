using System;

namespace _04_Array
{
	class Program
	{
		static void Main()
		{
			var ints = new int[7];
			var c = new char[7];

			var value = (int)c[0];
			var value1 = c[0].ToString();
			var str = "12345" + value1 + "67890";

			Console.WriteLine(str);
		}
	}
}
