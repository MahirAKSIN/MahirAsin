using System;

namespace Proje_04_Reference_Type
{
    class Program
    {

        class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

        }
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Mane";
            kisi.Yas = 28;

            Console.WriteLine($"{kisi.Ad} {kisi.Yas} yasindadir");
            Console.ReadLine();


            Kisi person = new Kisi();

            person.Ad = "Ahmet";
            person.Yas = 20;

            Console.WriteLine($"{person.Ad} {person.Yas} yasindadir");
            kisi = person;

            Console.WriteLine(kisi.Ad +""+ kisi.Yas);


            Console.ReadLine();
        }


    }
}
