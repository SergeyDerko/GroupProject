using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using TweetRefLib.TweetReference;

namespace TestWcfSite.Models.AnastasiaNepomiluyev
{
    public class Twitter
    {
        public virtual string UserName { get; set; }
        public virtual int CountOfPosts { get; set; }

        public IList<string> Posts { get; set; }

        public void GetTweets()
        {
            try
            {
                Posts = new List<string>();
                TweeterClient client = new TweeterClient();
                string[] array = client.GetTweets(UserName, CountOfPosts);
                if (array != null)
                {
                    foreach (string item in array)
                        Posts.Add(item);
                }
                client.Close();
            }
            catch (EndpointNotFoundException e)
            {
                Posts = new List<string>();
            }

        }
    }
}