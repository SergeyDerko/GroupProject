using System;

namespace _003_Array
{
	class Program
	{
		static void Main()
		{
			//var list = new List<string>() {"1", "2", "3"};
			var list = "12345678901234567890";
			for (int i = 0, j = 0; i < list.Length; i++, j--)
			{
				Console.ForegroundColor = (ConsoleColor) (i%15);
				Console.Write(list[i]);
			}

			var user = new User();
			user.ChangeWorkEvent += x => { Console.WriteLine("1: " + x); };
			user.ChangeWorkEvent += x => { Console.WriteLine("2: " + x); };
			Console.ForegroundColor = ConsoleColor.White;
			user.OnChangeWorkEvent("Intel");

		}
	}

	internal class User
	{
		public string Name { get; set; }
		public string SName { get; set; }
		public int Age { get; set; }
		public event Action<object> ChangeWorkEvent;

		public virtual void OnChangeWorkEvent(object obj)
		{
			ChangeWorkEvent?.Invoke(obj);
		}
	}
}
