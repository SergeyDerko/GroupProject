using Class.Helper;

namespace Class.Model
{
    public class MyClass : BaseClass, IMyInterface
    {
        public string Show()
        {
            return SName +" "+ Name+" " + Age;
        }
    }
}