using System.Collections.Generic;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace TweetLib
{
    [ServiceContract]
    interface ITweeter
    {
        Task<string> GetAccessToken();

        [OperationContract]
        IEnumerable<string> GetTweets(string userName, int count);
    }
}
