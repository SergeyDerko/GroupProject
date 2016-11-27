namespace Lib1
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, SName: {SName}, Age: {Age}";
        }
    }
}
