using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.TestWcfCommon
{
    public class Interlocutor
    {
        public ServiceHost ServiceHost { get; private set; }
        public string Login { get; private set; }

        public Interlocutor(ServiceHost host, string loginName)
        {
            ServiceHost = host;
            Login = loginName;
        }

        public override bool Equals(object obj)
        {
            return (obj is Interlocutor) ? this.Login == (obj as Interlocutor).Login : false;
        }
    }
}
