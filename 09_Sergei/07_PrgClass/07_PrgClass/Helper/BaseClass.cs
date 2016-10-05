

using System.Collections.Specialized;

namespace _07_PrgClass.Helper
{
    public class BaseClass : IBaseInterface 
    {
        public  string ToString()
        {
            return base.ToString();
        }

        public string Name { get; set; }

        string IBaseInterface.SName
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string Age { get; set; }

        public string SName()
        {
            throw new System.NotImplementedException();
        }
    }
}
