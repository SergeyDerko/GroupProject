using System;
using _09_NewClass.Model;

namespace _09_NewClass.Helper
{
    public class BaseClass: BaseInterface
   
    {
        public string Name { get; set; }
        public string SName { get; set; }
        public string Age { get; set; }
        public static string Show()
          
        {
            return Name + SName + Age;
        }
    }
}