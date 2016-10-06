
using _07_PrgClass.Helper;

namespace _07_PrgClass.Model
{
    public class MyClass : BaseClass , IMyClass
    {
        private string  Name { get; set; }
        public string Show()
        {
            return Name+"\n"+SName+"\n"+Age;
        }
    }
}

