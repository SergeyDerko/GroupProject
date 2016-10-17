using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Zoo.Modya
{
    public interface IZozya
    {
        brain Eatbrain { get; set; }
        goo Depature { get; set; }
    }

    public enum brain
    {
        want = 0,
        think = 1,
        hate = 2,
    }

    public enum goo
    {
        run = 0,
        jump = 1,
        slower = 2,
    }
}
