using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TestWcfCommon;

namespace TweetLib
{
    public class Twitter: ITweeter
    {
        const string oAuthConsumerSecret = "EEmNApm07ygRSPr3qO7lXsJLKz4dFRuLPv327i2drCeoT9DERv";
        const string oAuthConsumerKey = "SqUf7jLmR0gTZqq1U8gS4lfDX";
        private string accessToken;

        public async Task<string> GetAccessToken()
        {
            Logger.Enter("Enter to GetAccessToken Method");
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.twitter.com/oauth2/token ");
            var customerInfo = Convert.ToBase64String(new UTF8Encoding()
                                      .GetBytes(oAuthConsumerKey + ":" + oAuthConsumerSecret));
            request.Headers.Add("Authorization", "Basic " + customerInfo);
            request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8,
                                                                      "application/x-www-form-urlencoded");

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();
            var serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(json);
            Logger.Leave("Leave from GetAccessToken Method");
            return item["access_token"];
        }

        public IEnumerable<string> GetTweets(string userName, int count)
        {
            try
            {
                Logger.Enter("Enter to GetTweets Service");
                if (accessToken == null)
                {
                    Logger.Info("Go to GetAccessToken");
                    accessToken = GetAccessToken().Result;
                    Logger.Info("Get access token");
                }
                else Logger.Info("Get access token = "+ accessToken);
                var requestUserTimeline = new HttpRequestMessage(HttpMethod.Get,
                    string.Format(
                        "https://api.twitter.com/1.1/statuses/user_timeline.json?count={0}&screen_name={1}&trim_user=1&exclude_replies=1",
                        count, userName));
                requestUserTimeline.Headers.Add("Authorization", "Bearer " + accessToken);
                var httpClient = new HttpClient();
                HttpResponseMessage responseUserTimeLine = httpClient.SendAsync(requestUserTimeline).Result;
                var serializer = new JavaScriptSerializer();
                dynamic json = serializer.Deserialize<object>(responseUserTimeLine.Content.ReadAsStringAsync().Result);
                var enumerableTweets = (json as IEnumerable<dynamic>);

                if (enumerableTweets == null)
                {
                    return null;
                }
                var value = enumerableTweets.Select(t => (string) (t["text"].ToString()));
                Logger.Info(String.Format("UserName:{0}; Count of tweets:{1}; Find to return:{2}", userName, count,
                    value.Count()));
                Logger.Leave("Leave from GetTweets Service");
                return value;
            }
            catch (Exception e)
            {
                Logger.Error(e.ToString());
                return new List<string>();
            }

        }
    }
}
