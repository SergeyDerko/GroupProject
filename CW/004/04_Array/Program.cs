using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Array
{
	class Program
	{
		static void Main()
		{
			var users = Users();
			ShowUsers(users);
			users.Sort();
			ShowUsers(users);

			var list = new List<User>
			{
				new User
				{
					Name = "John",
					SName = "",
					Age = 66
				}
			};

			list.AddRange(users);

			ShowUsers(list);
			list.Sort();
			ShowUsers(list);

			foreach (var u in list)
			{
				if (u.Age == 33)
				{
					Test(u);
				}
			}
			ShowUsers(list);
			Console.ReadKey();
		}

		private static List<User> Users()
		{
			return new List<User>()
			{
				new User
				{
					Name = "John",
					SName = "",
					Age = 33
				},
				new User
				{
					Name = "John",
					SName = "",
					Age = 44
				},
				new User
				{
					Name = "John",
					SName = "",
					Age = 11
				},
				new User
				{
					Name = "John",
					SName = "",
					Age = 22
				},
			};
		}

		private static void ShowUsers(List<User> users)
		{
			foreach (var user in users)
			{
				Console.WriteLine(user);
			}
			Console.WriteLine("----------------");
		}

		private static void Test(User user)
		{
			user.Age = 8;
		}

		private static int Test(ref int a)
		{
			a += 2;
			return a;
		}
	}
}