using System;
using RandomNameGenerator;

namespace _501_GenObjects
{
    class User : IUser
    {
        public string Name { set; get; }
        public string SName { get; set; }
        public DateTime DateBirth { get; set; }
        Random rand = new Random();
        Gender gender { get; set; }
        

        public User()
        {
                
        }
    }
}
