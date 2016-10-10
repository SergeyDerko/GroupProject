using _09_NewClass.Helper;

namespace _09_NewClass.Model
{
    internal class MyClass: BaseClass, IMyInterface
    {
        public string Show()
        {
            return Name+SName + Age;
        }

    }

}