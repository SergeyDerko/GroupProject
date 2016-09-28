using System;

namespace _04_Array
{
	class Program
	{
		static void Main()
		{
			try
			{
				var strings = new string[3];
				if (strings[0] == null)
				{
					((string)null).Split(' ');
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("NullReferenceException" + e);
			}
		}
	}
}
