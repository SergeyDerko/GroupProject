using System.Runtime.Serialization;

namespace ServicesViewerLib
{
    [DataContract]
    public class OneService
    {
        [DataMember]
        public string BehaviorName { get; set; }
        [DataMember]
        public string ServiceBehaviorConfiguration { get; set; }
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string EndpointBinding { get; set; }
        [DataMember]
        public string EndpointContract { get; set; }
        [DataMember]
        public string BaseAddress { get; set; }
    }
}

