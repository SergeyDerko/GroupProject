using System;

namespace _04_Array
{
	public class User : IComparable<User>
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string SName { get; set; }

		/// <summary>
		/// Реализуем интерфейс IComparable<T>
		/// </summary>
		public int CompareTo(User obj)
		{
			if (Age > obj.Age)
				return 1;
			if (Age < obj.Age)
				return -1;
			return 0;
		}



		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}, SName: {SName}";
		}
	}
}