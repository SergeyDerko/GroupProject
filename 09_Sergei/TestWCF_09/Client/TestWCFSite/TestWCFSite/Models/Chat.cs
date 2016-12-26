using System;

namespace TestWCFSite.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string IpAdress { get; set; }
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
    }
}