using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            Console.WriteLine(creditManager);
            creditManager.calculate();
            loggerService.Log(); 
        }

        public void KrediOnBilgilendirmesi(List<ICreditManager> krediler)
        {
             foreach(var kredi in krediler)
            {
                kredi.calculate();
            }
        }
    }
}
