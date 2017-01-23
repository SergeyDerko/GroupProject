using System.Runtime.Serialization;

namespace ServicesViewerLib
{
        [DataContract]
        public class ValidationFault
        {
            [DataMember]
            public bool Result { get; set; }
            [DataMember]
            public string Message { get; set; }
            [DataMember]
            public string Description { get; set; }
        }


        [DataContract]
        public class FileFound
        {
            [DataMember]
            public bool Result { get; set; }
            [DataMember]
            public string Message { get; set; }
            [DataMember]
            public string Description { get; set; }
        }
}
