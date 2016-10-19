using System;

namespace _012_try
{// Создадим структуру


    internal class User
    {
        public string Name { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        public static User NewUser()
        {
            return new User
            {
                Age = new Random().Next(18, 100),
                Name = Guid.NewGuid().ToString("N").ToUpper(),
                SName = Guid.NewGuid().ToString("N").ToUpper(),
            };
        }
    }
}