using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public interface IMeth
    {
        string GetDescription();
        string ItemProperty { get; }
    }
}
