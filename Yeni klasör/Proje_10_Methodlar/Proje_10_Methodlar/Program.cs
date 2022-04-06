using System;

namespace Proje_10_Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Yaz();
            //Yaz1("Mahir");
            //Topla(10, 10);
            //Topla4();

            // Topla3();
            void Yaz()
            {
                Console.WriteLine("Hallo Wissen");
            }
            void Yaz1(String name)
            {
                Console.WriteLine("Hallo " + name + " willkommen");
            }
            void Topla3()
            {
                Console.Write("Birinci sayiyi giriniz : ");
                int sayi1 = int.Parse(Console.ReadLine());

                Console.Write("ikinci sayiyi giriniz : ");
                int sayi2 = int.Parse(Console.ReadLine());


                Console.WriteLine("Toplam :" + sayi2 + sayi1);
            }
            void Topla(int a, int b)
            {
                //int a = 10, b = 20;
                Console.WriteLine(a + b);
            }
            void Topla4()
            {
                Console.Write("Birinci sayiyi giriniz : ");
                int sayi1 = int.Parse(Console.ReadLine());

                Console.Write("ikinci sayiyi giriniz : ");
                int sayi2 = int.Parse(Console.ReadLine());


                Console.WriteLine($"Toplam :{(sayi1 + sayi1)}");
            }



            Console.ReadLine();
        }
    }
}
