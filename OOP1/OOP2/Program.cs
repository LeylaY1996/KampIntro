using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.MusteriNo = "12345";
            customer1.Adi = "leyla";
            customer1.Soyadi = "yılmaz";
            customer1.TcNo = "12345678";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.SirketAdi = "Kodlama";
            customer2.MusteriNo = "123434";
            customer2.VergiNo = "123456789";
        }
    }
}
