namespace Lib2
{
    public class User : IUser
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, SName: {SName}, Age: {Age}";
        }
    }
}
