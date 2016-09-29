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

			var array = users.ToList();
			array.AddRange(list);

			ShowUsers(users);
			foreach (var u in users)
			{
				if (u.Age == 33)
				{
					Test(u);
				}
			}
			ShowUsers(users);
		}

		private static User[] Users()
		{
			return new[]
			{
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
			};
		}

		private static void ShowUsers(User[] users)
		{
			foreach (var user in users)
			{
				Console.WriteLine(user);
			}
		}

		private static User Test(User user)
		{
			user.Age += 2;
			return user;
		}

		private static int Test(ref int a)
		{
			a += 2;
			return a;
		}
	}
}