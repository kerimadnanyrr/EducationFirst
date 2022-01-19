using System;

namespace EducationFirst
{
    class Program
    {
        static void Main(string[] args)
        {
           

            object a = 50;
            object b = "aaaaa";
            float piSayisi = 3.14F;
            double piDouble = 3.1457687d;
            bool control = true;
            char words = 'a';
            string hello= "Hello";
            sbyte eksideger = -128;
            byte deger = 56; //255 e kadar sayılar
            uint sayi3 = 1;//4 byte pozitif sayılar



            Console.WriteLine("Değerler"+piSayisi);
            Console.WriteLine("Değerler"+ piDouble);
            Console.WriteLine("Değerler"+ control);
            Console.WriteLine("Değerler"+ words);
            Console.WriteLine("Değerler"+ hello);
            Console.WriteLine("Değerler" + eksideger);
            Console.WriteLine("Değerler" + deger);
            Console.WriteLine("Değerler" + sayi3);




        }
    }
}
