using System;

namespace Diziler
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Dizi Tanımlama

            string [] hayvanlar = new string[5];

            string [] renkler = {"kırmızı", "mavi","beyaz"};

            int [] dizi;
            dizi = new int [5];

            // Dizilere değer atama ve erişim

            hayvanlar[2] = "ayı";
            hayvanlar[4] = "kuş";

            dizi [0] = 10;
            dizi [1] = 15;

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[2]);
            Console.WriteLine(dizi[1]);


            //Döngülerle dizi kullanımı

            Console.WriteLine("Dizi Uzunluğunu Giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int [diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("dizinin {0}. elemanını giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
                
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+= sayi;

            }

            Console.WriteLine(toplam/diziUzunlugu);




        }
    }
}