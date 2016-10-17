using System;

namespace _04_Prg
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//throw new NullReferenceException();
				Console.WriteLine("Test");
			}
			catch (Exception)
			{
				Console.WriteLine("Bad");
			}



			var ar = new string [] {"1 + 1", "2 + 2", "3 + 3"};
			foreach (var s in ar)
			{
				var pr = s.Split(Convert.ToChar(" "));
				Calc(pr);
			}
			Console.ReadKey();
		}

		private static void Calc(string[] pr)
		{
			if (pr.Length != 3) throw new ArgumentException();
			var a = int.Parse(pr[0]);
			var b = int.Parse(pr[2]);
			int z;
			var o = pr[1];
			switch (o)
			{
				case "+":
					z = a + b;
					break;
				case "-":
					z = a - b;
					break;
				case "*":
					z = a * b;
					break;
				case "/":
					z = a / b;
					break;
				default:
					throw new ArgumentException();
			}
			Console.WriteLine($"{a} {o} {b} = {z}");
		}
	}
}
