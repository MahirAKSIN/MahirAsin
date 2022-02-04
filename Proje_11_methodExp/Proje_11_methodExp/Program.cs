using System;

namespace Proje_11_methodExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            karsilastirma();

            void karsilastirma()
            {
                int sayac = 5;
                bool state = true;
                int puan = 50;
                Console.WriteLine($"Caniniz :{sayac}\nPuaniniz : {puan} ");
                int rast = rastgeleSayi();
                Console.WriteLine(rast);


                while (sayac > 0)
                {
                    int tahmin = sayiGir();
                    if (tahmin == rast)
                    {
                        Console.WriteLine("Tebrikler dogru tahmin");
                        state = true;
                        break;
                    }
                    else
                    {
                        sayac--;
                        puan -= 10;
                        state = false;
                        Console.WriteLine("Yanlis tahmin.Kalan caniniz : " + sayac);
                        Console.WriteLine("Puaniniz : " + puan);
                    }
                }
                if (state)
                {
                    Console.WriteLine("Kalan caniniz : " + sayac);
                    Console.WriteLine("Kazandiginiz  : " + puan + " kaldi. ");
                }
                else
                    Console.WriteLine("Kaybetiniz");
            }
            int sayiGir()
            {
                Console.WriteLine("Sayi giriniz :");
                int girilenSayi = int.Parse(Console.ReadLine());
                return girilenSayi;
            }
            int rastgeleSayi()
            {
                Random rnd = new Random();
                int sayiRnd = rnd.Next(1, 100);
                // Console.WriteLine( sayiRnd );
                return sayiRnd;
            }

            Console.ReadLine();
        }
    }
}
