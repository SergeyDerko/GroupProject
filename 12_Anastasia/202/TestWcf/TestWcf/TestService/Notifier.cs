using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using Common.TestWcfCommon;
using TestWcfCommon;

namespace TestService
{

    /*public class Notifier:INotifier
    {
        public IList<Interlocutor> InterlocutorList { get; private set; }

        public IList<Interlocutor> Send(Interlocutor interlocator)
        {
            if(InterlocutorList == null)
                InterlocutorList = new List<Interlocutor>();
            if(!InterlocutorList.Contains(interlocator))
                InterlocutorList.Add(interlocator);
            else throw new Exception(message: "Вы уже зарегистрированы в системе!");
            return InterlocutorList.ToList();
        }

    
    }*/
}