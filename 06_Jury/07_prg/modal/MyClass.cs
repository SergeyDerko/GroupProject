using System;
using System.Runtime.InteropServices;
using _07_prg.helper;

namespace _07_prg.modal
{
    class MyClass:BaseClass,IMyClass
    {
        public string Show()
        {
            return Name + SName;


        }

        
    }
}