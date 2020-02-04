using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            sayi = SayiGir();
            YaziylaYaz(sayi);


            Console.ReadLine();

        }
        static int SayiGir()
        {
            string s;
            Console.Write("Bir sayı giriniz= ");
            s = Console.ReadLine();
            int b = int.Parse(s);
            return b;

        }

        static void YaziylaYaz(int sy)
        {
            //Console.WriteLine(sy);
            if (sy == 0)
            {
                SıfırYaz(sy);
            }
            if (sy < 10)
                BirlikYaz(sy);
            else if (sy < 1000)
            {
                YuzlukYaz((sy % 1000) / 100);
                OnlukYaz((sy % 100)/10);
                BirlikYaz((sy % 10));


            }
           

        }
        static void SıfırYaz(int b)
        {
            if (b == 0) Console.WriteLine("Sıfır");

        }
        static void BirlikYaz(int b)
        {
            switch (b) { 
            case 1: Console.Write("bir "); break;
                case 2: Console.Write("iki "); break;
                case 3: Console.Write("üç "); break;
                case 4: Console.Write("dört "); break;
                case 5: Console.Write("beş "); break;
                case 6: Console.Write("Altı "); break;
                case 7: Console.Write("Yedi "); break;
                case 8: Console.Write("Sekiz "); break;
                case 9: Console.Write("Dokuz "); break;
        }
        }

        static void OnlukYaz(int b)
        {
            switch (b)
            {
                case 1: Console.Write("On "); break;
                case 2: Console.Write("Yirmi "); break;
                case 3: Console.Write("Otuz "); break;
                case 4: Console.Write("Kırk "); break;
                case 5: Console.Write("Elli "); break;
                case 6: Console.Write("Altmış "); break;
                case 7: Console.Write("Yetmiş "); break;
                case 8: Console.Write("Seksen "); break;
                case 9: Console.Write("Doksan "); break;
            }


        }
        static void YuzlukYaz(int b)
        {
            switch (b)
            {
                case 1: Console.Write("Yüz "); break;
                case 2: Console.Write("İkiyüz "); break;
                case 3: Console.Write("Üçyüz "); break;
                case 4: Console.Write("Dörtyüz "); break;
                case 5: Console.Write("Beşyüz "); break;
                case 6: Console.Write("Altıyüz "); break;
                case 7: Console.Write("Yediyüz "); break;
                case 8: Console.Write("Sekizyüz "); break;
                case 9: Console.Write("Dokuzyüz "); break;
            }


        }
    }
}