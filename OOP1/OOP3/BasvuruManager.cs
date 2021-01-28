using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager)
        {
            Console.WriteLine(creditManager);
            creditManager.calculate();
        }

        public void KrediOnBilgilendirmesi(List<ICreditManager> krediler)
        {

        }
    }
}
