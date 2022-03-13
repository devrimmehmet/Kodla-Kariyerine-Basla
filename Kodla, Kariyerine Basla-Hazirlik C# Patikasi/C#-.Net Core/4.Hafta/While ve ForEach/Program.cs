using System;

namespace While_ve_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak console'dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console a yazdıran program.
            
            Console.Write("Lütfen Bir Sayı Giriniz.");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<(sayi+1))
            {
                toplam=toplam+sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama :"+ (toplam/sayi));
            Console.WriteLine("***********************************************");

            // 'a'dan 'z'e kadar tüm harfleri console yazdır.
            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("***********************************************");
            // foreach 

            string[] arabalar ={"BMW","FORD","TOYOTA","NİSSAN"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
