namespace _04_Array
{
	internal class User
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string SName { get; set; }

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}, SName: {SName}";
		}
	}
}