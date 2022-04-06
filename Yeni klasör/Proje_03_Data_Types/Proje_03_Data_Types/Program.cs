using System;

namespace Proje_03_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "*************** -DATA TYPE- ***************";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            //Console.WriteLine("max byte : " + byte.MaxValue);
            //Console.WriteLine("min byte : " + byte.MinValue);
            //Console.WriteLine("RAM-Size : " + sizeof(byte));
            //Console.WriteLine("******************************");
            //Console.ReadLine();

            //Console.WriteLine("max ushort : " + ushort.MaxValue);
            //Console.WriteLine("min ushort : " + ushort.MinValue);
            //Console.WriteLine("RAM-Size : " + sizeof(ushort));
            //Console.WriteLine("******************************");
            //Console.ReadLine();

            //Console.WriteLine("max uint : " + uint.MaxValue);
            //Console.WriteLine("min uint : " + uint.MinValue);
            //Console.WriteLine("RAM-Size : " + sizeof(uint));
            //Console.WriteLine("******************************");
            //Console.ReadLine();


            //Console.WriteLine("max ulong : " + ulong.MaxValue);
            //Console.WriteLine("min ulong : " + ulong.MinValue);
            //Console.WriteLine("RAM-ulong : " + sizeof(ulong));
            //Console.WriteLine("******************************");
            //Console.ReadLine();


            //Console.WriteLine("Isaretli Tam Sayilar");
            //Console.WriteLine("");

            //Console.WriteLine("max sbyte : " + sbyte.MaxValue);
            //Console.WriteLine("min sbyte : " + sbyte.MinValue);
            //Console.WriteLine("RAM-sbyte : " + sizeof(sbyte));
            //Console.WriteLine("******************************");
            //Console.ReadLine();


            //Console.WriteLine("max short : " + short.MaxValue);
            //Console.WriteLine("min short : " + short.MinValue);
            //Console.WriteLine("RAM-short : " + sizeof(short));
            //Console.WriteLine("******************************");
            //Console.ReadLine();

            //Console.WriteLine//Console.WriteLine("max float : " + float.MaxValue);
            //Console.WriteLine("min float : " + float.MinValue);
            //Console.WriteLine("RAM-float : " + sizeof(float));
            //Console.WriteLine("******************************");
            //Console.ReadLine();max int : " + int.MaxValue);
            //Console.WriteLine("min int : " + int.MinValue);
            //Console.WriteLine("RAM-int : " + sizeof(int));
            //Console.WriteLine("******************************");
            //Console.ReadLine();


            //Console.WriteLine("max long : " + long.MaxValue);
            //Console.WriteLine("min long : " + long.MinValue);
            //Console.WriteLine("RAM-long : " + sizeof(long));
            //Console.WriteLine("******************************");
            //Console.ReadLine();

            //Console.WriteLine("max float : " + float.MaxValue);
            //Console.WriteLine("min float : " + float.MinValue);
            //Console.WriteLine("RAM-float : " + sizeof(float));
            //Console.WriteLine("******************************");
            //Console.ReadLine();

            //Console.WriteLine("max double : " + double.MaxValue);
            //Console.WriteLine("min double : " + double.MinValue);
            //Console.WriteLine("RAM-double : " + sizeof(double));
            //Console.WriteLine("******************************");
            //Console.ReadLine();


            //Console.WriteLine($"max decimal : { decimal.MaxValue:0.00}");
            //Console.WriteLine($"min decimal : { decimal.MinValue:0.00}");
            //Console.WriteLine($"RAM-decimal : {sizeof(decimal):0.00}");
            //Console.WriteLine("******************************");
            //Console.ReadLine();



            //Console.WriteLine("max char : " + (int)char.MaxValue);
            //Console.WriteLine("min char : " + (int)char.MinValue);
            //Console.WriteLine("RAM-char : " + (int)sizeof(char));
            //Console.WriteLine("******************************");
            //Console.ReadLine();

      
            unsafe {

                Console.WriteLine(sizeof(DateTime));
            }

           
           


            //553-773-18-01

            // int q = 0;
            //  Console.WriteLine("Bir sayi giriniz : ");
            // q = Convert.ToInt32(Console.ReadLine());

            //fibbonaci

            //Sayisi(q);
            // Console.ReadLine
            Console.ReadLine();

        }



        static void fibbonaciSayisi(int sayi)
        {
            int s1 = 0, s2 = 1, toplam;

            for (int i = 0; i <= sayi; i++)
            {
                Console.WriteLine(s1);

                toplam = s1 + s2;
                s1 = s2;
                s2 = toplam;
            }
        }
    }
}
