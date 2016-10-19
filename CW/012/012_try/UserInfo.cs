using System;

namespace _012_try
{
    struct UserInfo
    {
        public string Name;
        public byte Age;

        public UserInfo(string Name, byte Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void WriteUserInfo()
        {
            Console.WriteLine("Имя: {0}, возраст: {1}", Name, Age);
        }
    }
}