namespace _09_Prg_oop.Model
{
    internal class User
    {
         string Name { get; set; }
         string SName { get; set; }
         int Age { get; set; }

        public User(string name, string sname, int age)
        {
            Name = name;
            SName = sname;
            Age = age;
        }
    }
}