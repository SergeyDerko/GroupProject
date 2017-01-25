using System.Runtime.Serialization;

namespace TestWcfTypes.Expressions
{
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
}