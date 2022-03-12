using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //Expression 
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız!");
                break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız!");
                break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız!");
                break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız!");
                break;
                case 5:
                    Console.WriteLine("Mayıs Ayındasınız!");
                break;
                case 6:
                    Console.WriteLine("Haziran Ayındasınız!");
                break;
                default:
                    Console.WriteLine("Yanlış Veri Girişi !");
                break;
            }
            
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5: 
                    Console.WriteLine("İlkbahar Mevsimindesiniz");
                    break;
                default:
                break;
            }

            
        }
    }
}
