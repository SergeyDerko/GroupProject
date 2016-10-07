using _09_10_Class.Helper;

namespace _09_10_Class.Model
{
    public class MyClass : Base, IMyClass
    {
        public string Show()
        {
            return Name + SName + Age;
        }
        
    }

    public interface IMyClass
    {
        string Show();
    }
}