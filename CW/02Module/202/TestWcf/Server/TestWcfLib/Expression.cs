using System.Runtime.Serialization;

namespace TestWcfLib
{
    [DataContract]
    public class Expression
    {
        [DataMember]
        public decimal A { get; set; }

        [DataMember]
        public decimal B { get; set; }

        [DataMember]
        public MathAction MathAction { get; set; }
    }
    public enum MathAction
    {
        Sum = 1,
        Min = 2
    }
}