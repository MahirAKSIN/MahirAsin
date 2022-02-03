using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            String write = "Bir sayi giriniz :";
            Console.WriteLine(write);
            int input1 = Convert.ToInt32(Console.ReadLine());

            saydir(input1);
        }
        static void saydir(int input)
        {
            int count = 0, sayac = 0;

            for (int i = 0; i < input; i++)
            {

                if (i % 2 == 0)
                {
                    count += i;
                }
                else
                    sayac += i;
            }
            Console.WriteLine("Sayac Cift : " + count);
            Console.WriteLine("Sayac Tek : " + sayac);

        }
    }
}
