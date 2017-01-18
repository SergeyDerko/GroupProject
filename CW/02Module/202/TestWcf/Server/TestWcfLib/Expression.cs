using System.Runtime.Serialization;

namespace TestWcfLib
{
    [DataContract(Namespace = "CalcService")]
    [KnownType(typeof(ExpressionPlus))]
    public class Expression
    {
        [DataMember]
        public decimal A { get; set; }

        [DataMember]
        public decimal B { get; set; }

        [DataMember]
        public MathAction MathAction { get; set; }
    }

    [DataContract(Namespace = "CalcService")]
    public class ExpressionPlus : Expression
    {
        [DataMember]
        public decimal Z { get; set; }

        public override string ToString()
        {
            return $"{A} {MathAction} {B} = ";
        }
    }

    public enum MathAction
    {
        Sum = 1,
        Min = 2
    }
}