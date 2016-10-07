using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_home
{
    class IWorker:IUser, InterfaceUser
    {
        public string WhatIdo()
        {
            return "I work on my job.";
        }
    }
}
