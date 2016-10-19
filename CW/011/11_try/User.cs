using System;

namespace _11_try
{
    internal class User
    {
        private DateTime birthday;

        public User(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public User Test()
        {
            return this;
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public User()
        {
            
        }

        public event Action<object> BirthdayEvent;

        internal virtual void OnBirthday(object obj)
        {
            BirthdayEvent?.Invoke(obj);
        }
    }
}