using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Model
{
    class Fish : IMeth
    {
        public string Classer;
        public string Name;
        public int Size;
        public int Population;

        public string ItemProperty
        {
            get { return String.Format("{0} {1}", Classer, Name); }
        }

        public string GetDescription()
        {
            return String.Format("{0} {1} {2}\" {3}cm", Classer, Name, Population, Size);
        }
    }
}
