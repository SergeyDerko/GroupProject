using System;
using System.Threading.Tasks;
using TestWcfClientLib.CalcServiceReference;

namespace TestWcfSite.Models.Calc
{
    public class CalcModel : IDisposable, ICalc
    {
        private readonly CalcClient _client;

        public CalcModel()
        {
            _client = new CalcClient();
        }

        public void Dispose()
        {
            _client.Close();
        }

        public int Sum(int a, int b)
        {
            return _client.Sum(a, b);
        }

        public Task<int> SumAsync(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}