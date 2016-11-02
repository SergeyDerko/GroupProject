using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _503_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Name = Guid.NewGuid().ToString("N").ToUpper();
            user.SName = Guid.NewGuid().ToString("N").ToUpper();


        }
    }

}
