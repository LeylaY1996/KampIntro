using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> isimler = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            isimler.Add("Leyla");
            Console.WriteLine(isimler);
            Console.WriteLine("Hello World!");
        }
    }
}
