namespace _09_Prg_oop
{
    internal class User
    {
        public string Name { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        public User(string name, string sname, int age)
        {
            Name = name;
            SName = sname;
            Age = age;
        }
    }
}