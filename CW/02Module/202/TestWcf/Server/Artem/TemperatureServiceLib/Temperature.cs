using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureServiceLib
{
    
    public class Temperature: ITemperature
    {
        public string Temp()
        {
            var random = new Random();
            var tempCelcium = random.Next(0, 100);
            var tempFahrenheit = tempCelcium * (9 / 5) + 32;
            var tempKelvine = tempCelcium - 273;
            return $"tC = {tempCelcium}, tf = {tempFahrenheit}, tK = {tempKelvine}";
        }
    }
}
