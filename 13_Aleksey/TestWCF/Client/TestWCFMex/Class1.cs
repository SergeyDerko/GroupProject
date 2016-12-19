using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFMex.TestWCFMex;

namespace TestWCFMex
{
    class Programm
    {
        static void Main(string[] args)
        { CalcClient client = new CalcClient();

        // Используйте переменную "client", чтобы вызвать операции из службы.

        // Всегда закройте клиент.
        client.Close();
            
        }
       
       
    }
}
