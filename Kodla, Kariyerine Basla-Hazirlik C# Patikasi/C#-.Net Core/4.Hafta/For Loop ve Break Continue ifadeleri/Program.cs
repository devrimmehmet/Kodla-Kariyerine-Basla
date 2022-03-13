using System;

namespace For_Loop_ve_Break_Continue_ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < length; i++)
            //{
            //    //komutlar
            //}

            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz.");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*****************************************");
            // 1 ile 1000 arasındaki tek ve çift sayıların toplamını hesapla ve console yazdır.
            int tektoplam=0;
            int cifttoplam=0;
            int toplam=0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2==1)
                {
                    tektoplam=tektoplam+i;
                }
                else
                {
                    cifttoplam=cifttoplam+i;
                }
                

            }
            toplam=tektoplam+cifttoplam;
            Console.WriteLine("Tek Toplam Sonuç: "+tektoplam);
            Console.WriteLine("Çift Toplam Sonuç: "+cifttoplam);
            Console.WriteLine("Sonuç: "+toplam);
            Console.WriteLine("*****************************************");

            // break tamamen bitir 
            // continue sadece 1 turu atla.

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                {
                    continue;
                    
                }
                if(i==7)
                {
                    break;
                    
                }
                Console.WriteLine(i);
            }
        }
    }
}
