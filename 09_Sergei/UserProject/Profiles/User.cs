using UserProject.Interfaces;

namespace UserProject.Profiles
{
    internal class User : IUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}