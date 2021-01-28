using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IntiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            List<ICreditManager> krediler = new List<ICreditManager>() { };
            basvuruManager.KrediOnBilgilendirmesi(krediler);
        }


    }
}
