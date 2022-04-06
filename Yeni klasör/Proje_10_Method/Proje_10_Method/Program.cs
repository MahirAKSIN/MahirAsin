using System;

namespace Proje_10_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Topla(10, 10);

            Topla(10, 10, 10);

            Console.WriteLine(Topla(10, 10));
            Console.WriteLine(Topla(10, 10, 10));
            Console.ReadLine();
        }
        static int Topla(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            return (result);
        }
        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            int result = sayi1 + sayi2 + sayi3;
            return (result);


        }
    }

}


