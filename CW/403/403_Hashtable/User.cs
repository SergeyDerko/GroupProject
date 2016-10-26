using System;

namespace _403_Hashtable
{
    internal class User
    {
        public event Action<string> ChangeWork;

        internal virtual void OnChangeWork(string obj)
        {
            ChangeWork?.Invoke(obj);
        }
    }
}