using System;

namespace SuperListXUnitTestOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList<string> listem = new SuperList<string>();

            listem.Ekle("Ali");
            listem.Ekle("Onur");
            listem.Ekle("Selçuk");

            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
