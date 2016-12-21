using System.ServiceModel;

namespace TestWcf4Common
{
    
        [ServiceContract]
        public interface ICalc
        {
            [OperationContract]
            int Sum(int a, int b);
        }
    
}
