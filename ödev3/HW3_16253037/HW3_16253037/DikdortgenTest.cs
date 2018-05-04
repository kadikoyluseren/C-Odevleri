
// AD SOYAD : SEREN KADIKÖYLÜ
// ÖĞRENCİ NUMARASI : 16253037

using System;
namespace HW3_16253037
{
    class DikdortgenTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIKDORTGENIN HAREKET ETTIRILMESI");
            Console.Write("Kac ornek gormek istersiniz : ");
            int x = int.Parse(Console.ReadLine());
            Console.Clear();
            Dikdortgen dik = new Dikdortgen();
            Dikdortgen[] dizi = new Dikdortgen[x];
            Random rast = new Random();
            
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("________________________________________________________________________________");
                dik.En = rast.Next(1, 100);
                dik.Boy = rast.Next(1, 100);
                dik.X = rast.Next(-100,100);
                dik.Y = rast.Next(-100, 100);
                Console.WriteLine("\nKOSELERIN ILK KOORDINATLARI");
                dik.KoordinatYazdir();
                dik.Hareket(rast.Next(-100,100),rast.Next(-100,100));
                dik.KoordinatYazdir();
                Console.WriteLine("\nEn = "+dik.En);
                Console.Write("Boy= "+dik.Boy);
                dik.CevreAlanYazdir();

            }Console.WriteLine("________________________________________________________________________________");

            Console.ReadLine();
        }
    }
}