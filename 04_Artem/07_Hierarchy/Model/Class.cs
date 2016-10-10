using _07_Hierarchy.Helper;

namespace _07_Hierarchy.Model
{
    internal class Class : BaseClass, IMyInterface
    {
        public string Show()
        {
            return Name + Surname + Age;
        }
    }
}

