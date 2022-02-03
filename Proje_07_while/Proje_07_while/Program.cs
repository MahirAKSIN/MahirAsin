using System;

namespace Proje_07_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //while01();
            //while02();
            //while03();
            // while04();
            while05();

        }

        static void while01()
        {

            int sayi = 1, toplam = 0;

            while (sayi <= 5)
            {
                Console.WriteLine(sayi);
                toplam = toplam + sayi;
                sayi++;
            }
            Console.WriteLine("Toplam :  " + toplam);
            Console.ReadLine();



        }
        static void while02()
        {

            string input = "";

            while (input != "exit")
            {
                Console.WriteLine("Hello Word!");
                input = Console.ReadLine();

            }
            Console.ReadLine();
        }
        static void while03()
        {

            string input = "";
            do
            {
                Console.WriteLine("Hello Word!");
                input = Console.ReadLine();
            } while (input != "exit");

            Console.ReadLine();
        }
        static void while04()
        {
            string userName = "";
            int pass;
            bool state = false;
            do
            {
                if (state)
                {
                    Console.WriteLine("Giris Basarisiz");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Write("Kullanici adi :");
                userName = Console.ReadLine();
                Console.Write("Sifre :");
                pass = int.Parse(Console.ReadLine());
                state = true;

            } while (userName != "admin" || pass != 123);
            Console.WriteLine("tebrikler");
            Console.ReadLine();
        }
        static void while05()
        {

            int sayi, toplam = 0, sayac = 4;
            do
            {
                sayac--;
                Console.Write("Sayi giriniz : ");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;

            } while (toplam <= 50|| sayac < 0);
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Sayi adedi : " + sayac);
            Console.WriteLine("bitti");
            Console.ReadLine();
        }

    }
}
