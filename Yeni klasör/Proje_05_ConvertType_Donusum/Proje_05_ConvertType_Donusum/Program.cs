using System;

namespace Proje_05_ConvertType_Donusum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Isminizi giriniz : ");
            //String name = Console.ReadLine();
            //Console.WriteLine("");
            //Console.WriteLine($"Merhaba {name} hosgeldin ");

            //bool result = true;

            Console.Write("kenar1 gir :");
            int kanar1 =int.Parse(Console.ReadLine());


            Console.Write("kenar2 gir :");
            int kenar2 = int.Parse(Console.ReadLine());


            int cevre = 2*kanar1 + 2*kenar2;
            int alan = kanar1 * kenar2;
            Console.WriteLine("");
            Console.WriteLine("*******************");
            Console.WriteLine("Dikdortgenin Cevresi : " + cevre);
            Console.WriteLine("Dikdortgenin alan : " + alan);
            Console.WriteLine("*******************");


            //Console.Write("Sayi1 gir :");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Sayi2 gir :");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //int toplam = sayi1 + sayi2;
            //Console.WriteLine("");
            //Console.WriteLine("*******************");
            //Console.WriteLine("Toplam : " + toplam);
            //Console.WriteLine("*******************");



            //while (result)
            //{
            //    try
            //    {
            //        Console.WriteLine("");
            //        Console.Write("Bir sayi giriniz : ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("");
            //        Console.WriteLine(sayi);
            //        result = false;
            //        Console.WriteLine("");

            //    }
            //    catch
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Karakter girisi yapamazsınız.");
            //        result = true;
            //        Console.WriteLine("");

            //    }
            //}
            Console.ReadLine();
        }
    }
}
