using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişken isimleri küçük büyük harf duyarlıdır.
            //Değişken adları rakamla başlayamaz.
            //classname namespace class gibi özel isimler verilemez.
            //Aynı kod bloğu içinde aynı değişken birden fazla defa tanımlanamaz.
            //Değişken oluştururken işlem operatörü tanımlanamaz.
            Console.WriteLine("Hello World");

            string degisken =" ";
            if(degisken==" ")
            {

            }
            byte b=5;               // 1 byte yer kaplar
            sbyte c=5;              // 1 sbyte 
            short s = 5;            // bellekte 2 byte yer kaplar -32768 +32768
            ushort us=5;            // 2 byte yer kaplar
            Int16 i16=2;            // 2 byte
            int i=2;                // 4 byte
            Int32 i32=2;            // 4 byte
            Int64 i64=2;            // 8 byte 
            uint ui=2;              // 4 byte 
            long l=4;               // 8 byte 
            ulong ul=4;             // 8 byte
            
            //Reel sayılar
            float f=5;              // 4 byte  
            double d=5;             // 8 byte
            decimal de=5;           // 16 byte

            char ch='2';            // 2 byte 
            string str="Devrim";    // sınırsızdır.

            bool b2=true;
            bool b3=false;

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt); 

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=4.3;

            //Tüm değişken türleri bir objedir. Her türlü veriyi objecte atabiliriz object üst nesnedir.

            // string ifadeler
            string str1=string.Empty;
            str1="Devrim Mehmet";
            string ad="Devrim Mehmet";
            string soyad="Pattabanoğlu";
            string tamisim=ad+" "+ soyad;
            Console.WriteLine(tamisim); 

            // integer tanımlama şekilleri

            int integer1=5;
            int integer2=3;
            int integer3=integer1*integer2;


            bool bool1=10>2; // true atacak.

            string str20="20";
            int int20=20;

            string yeniDeger=str20+int20.ToString();

            Console.WriteLine(yeniDeger);

            int int21=int20+ Convert.ToInt32(str20);
            Console.WriteLine(int21);
            
            int int22 = int20+int.Parse(str20);
            Console.WriteLine(int22);
            
            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour=DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);
            Console.WriteLine(hour);
        }
    }
}
