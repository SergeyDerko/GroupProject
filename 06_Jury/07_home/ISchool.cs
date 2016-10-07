using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_home
{
    class ISchool : IUser, InterfaceUser
    {
        public string WhatIdo()
        {
            return "I study in school.";
        }

    }
}
