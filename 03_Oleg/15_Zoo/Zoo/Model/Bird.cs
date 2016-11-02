using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Model
{
    class Bird : IMeth
    {
        public string Subclass;
        public string Name;
        public int Size;
        public int Population;

        public string ItemProperty
        {
            get { return String.Format("{0} {1}", Subclass, Name); }
        }

        public string GetDescription()
        {
            return String.Format("{0} {1} {2}\" {3}cm", Subclass, Name, Population, Size);
        }
    }
}
