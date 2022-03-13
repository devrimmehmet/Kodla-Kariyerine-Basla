using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayiDizisi= {23,12,4,86,72,3,11,17};
            Console.WriteLine("***** Sırasız Liste *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            
            Console.WriteLine("***** Sıralı Liste *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi,2,2);//sayı dizisi elemanlarını kullanarak 2.indexten başlayarak 2tane indexi 0ladı.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            Console.WriteLine("***** ReSize *****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
