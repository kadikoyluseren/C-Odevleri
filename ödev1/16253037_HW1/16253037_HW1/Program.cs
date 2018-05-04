
// AD SOYAD : SEREN KADIKÖYLÜ
// ÖĞRENCİ NUMARASI : 16253037

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16253037_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("TAVSAN VE KAPLUMBAGANIN YARISINA HOSGELDINIZ!");
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("--> Yarisin adimlarini satir satir gormek icin 1'e basin");
                Console.WriteLine("--> Yarisi canli izlemek icin 2'ye basin");
                Console.WriteLine("--> Aciklamalarla gormek icin 3'e basin");
                Console.WriteLine("--> Cikis icin 4'e basin");
                Console.Write("Seciminiz : ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Clear();
                    int tavsanKare = 1;
                    int kaplumbagaKare = 1;
                    Random rastgele = new Random();

                    while (tavsanKare < 70 && kaplumbagaKare < 70)
                    {
                        /* KAPLUMBAGA */
                        int K = rastgele.Next(1, 11);

                        if (K <= 5 && K >= 1)
                        {
                            kaplumbagaKare = kaplumbagaKare + 3;
                        }

                        else if (K >= 6 && K <= 7)
                        {
                            kaplumbagaKare = kaplumbagaKare - 6;
                            if (kaplumbagaKare < 1)
                                kaplumbagaKare = 1;
                        }

                        else if (K >= 8 && K <= 10)
                        {
                            kaplumbagaKare = kaplumbagaKare + 1;
                        }

                        /* TAVSAN */
                        int T = rastgele.Next(1, 11);

                        if (T <= 2 && T >= 1)
                        {
                            tavsanKare = tavsanKare + 0;
                        }

                        else if (T <= 4 && T >= 3)
                        {
                            tavsanKare = tavsanKare + 9;
                        }

                        else if (T == 5)
                        {
                            tavsanKare = tavsanKare - 12;
                            if (tavsanKare < 1)
                                tavsanKare = 1;
                        }

                        else if (T <= 8 && T >= 6)
                        {
                            tavsanKare = tavsanKare + 1;
                        }

                        else if (T <= 10 && T >= 9)
                        {
                            tavsanKare = tavsanKare - 2;
                            if (tavsanKare < 1)
                                tavsanKare = 1;
                        }

                        /* YOL */

                        if (kaplumbagaKare < tavsanKare)
                        {
                            for (int i = 0; i < kaplumbagaKare - 1; i++)
                            {
                                Console.Write("_");
                            }
                            Console.Write("K");

                            for (int i = 0; i < tavsanKare - kaplumbagaKare - 1; i++)
                            {
                                Console.Write("_");
                            }
                            Console.Write("T");
                            for (int i = 0; i < 70 - tavsanKare; i++)
                            {
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");
                        }

                        else if (kaplumbagaKare > tavsanKare)
                        {
                            for (int i = 0; i < tavsanKare - 1; i++)
                            {
                                Console.Write("_");
                            }
                            Console.Write("T");

                            for (int i = 0; i < kaplumbagaKare - tavsanKare - 1; i++)
                            {
                                Console.Write("_");
                            }
                            Console.Write("K");
                            for (int i = 0; i < 70 - kaplumbagaKare; i++)
                            {
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");
                        }

                        else
                        {
                            for (int i = 0; i < tavsanKare - 1; i++)
                            {
                                Console.Write("_");
                            }
                            Console.Write("OUCH");
                            for (int i = 0; i < 67 - tavsanKare; i++)
                            {
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");

                        }
                    }

                    /* SON */
                    if (kaplumbagaKare > tavsanKare)
                        Console.WriteLine("KAPLUMBAGA KAZANDI!!! OLEY!!\n\n");
                    else if (tavsanKare > kaplumbagaKare)
                        Console.WriteLine("TAVSAN KAZANDI. YUH\n\n");
                    else
                        Console.WriteLine("BERABERE\n\n");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (secim == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    int tavsanKare = 1, kaplumbagaKare = 1;
                    Random rastgele = new Random();

                    while (tavsanKare < 70 && kaplumbagaKare < 70)
                    {
                        /* KAPLUMBAGA */
                        int K = rastgele.Next(1, 11);

                        if (K <= 5 && K >= 1)
                        {
                            kaplumbagaKare = kaplumbagaKare + 3;
                        }

                        else if (K >= 6 && K <= 7)
                        {
                            kaplumbagaKare = kaplumbagaKare - 6;
                            if (kaplumbagaKare < 1)
                                kaplumbagaKare = 1;
                        }

                        else if (K >= 8 && K <= 10)
                        {
                            kaplumbagaKare = kaplumbagaKare + 1;

                        }
                        System.Threading.Thread.Sleep(300);

                        /* TAVSAN */
                        int T = rastgele.Next(1, 11);

                        if (T <= 2 && T >= 1)
                        {
                            tavsanKare = tavsanKare + 0;
                        }

                        else if (T <= 4 && T >= 3)
                        {
                            tavsanKare = tavsanKare + 9;
                        }

                        else if (T == 5)
                        {
                            tavsanKare = tavsanKare - 12;
                            if (tavsanKare < 1)
                                tavsanKare = 1;
                        }

                        else if (T <= 8 && T >= 6)
                        {
                            tavsanKare = tavsanKare + 1;
                        }

                        else if (T <= 10 && T >= 9)
                        {
                            tavsanKare = tavsanKare - 2;
                            if (tavsanKare < 1)
                                tavsanKare = 1;
                        }
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("-----------------------TAVSAN KAPLUMBAGA YARISI-----------------------\n");

                        /* YOL */
                        if (kaplumbagaKare < tavsanKare)
                        {
                            for (int i = 0; i < kaplumbagaKare - 1; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("K");

                            for (int i = 0; i < tavsanKare - kaplumbagaKare - 1; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("T");

                            for (int i = 0; i < 70 - tavsanKare; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");

                        }

                        else if (kaplumbagaKare > tavsanKare)
                        {
                            for (int i = 0; i < tavsanKare - 1; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("T");

                            for (int i = 0; i < kaplumbagaKare - tavsanKare - 1; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("K");

                            for (int i = 0; i < 70 - kaplumbagaKare; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");
                        }

                        else
                        {
                            for (int i = 0; i < tavsanKare - 1; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("OUCH");

                            for (int i = 0; i < 67 - tavsanKare; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");
                        }

                    }

                    /* SONUC */
                    if (kaplumbagaKare > tavsanKare)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t\t      KAPLUMBAGA KAZANDI!!! OLEY!!\n\n");
                    }
                    else if (tavsanKare > kaplumbagaKare)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\t\t         TAVSAN KAZANDI . YUH\n\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t\t        BERABERE\n\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (secim == "3")
                {
                    Console.Clear();
                    int tavsanKare = 1, kaplumbagaKare = 1;
                    Random rastgele = new Random();

                    while (tavsanKare < 70 && kaplumbagaKare < 70)
                    {
                        /* KAPLUMBAGA */
                        int K = rastgele.Next(1, 11);
                        Console.WriteLine("Kaplumbaga icin : " + K);

                        if (K <= 5 && K >= 1)
                        {
                            Console.Write("3 saga");
                            kaplumbagaKare = kaplumbagaKare + 3;
                        }

                        else if (K >= 6 && K <= 7)
                        {
                            Console.Write("6 sola");
                            kaplumbagaKare = kaplumbagaKare - 6;
                            if (kaplumbagaKare < 1)
                                kaplumbagaKare = 1;
                        }

                        else if (K >= 8 && K <= 10)
                        {
                            Console.Write("1 saga");
                            kaplumbagaKare = kaplumbagaKare + 1;
                        }
                        Console.WriteLine("\nKaplumbaga " + kaplumbagaKare + ". karede");

                        /* TAVSAN */
                        int T = rastgele.Next(1, 11);
                        Console.WriteLine("Tavsan icin : " + T);

                        if (T <= 2 && T >= 1)
                        {
                            Console.WriteLine("hareket yok");
                            tavsanKare = tavsanKare + 0;
                        }

                        else if (T <= 4 && T >= 3)
                        {
                            Console.WriteLine("9 saga");
                            tavsanKare = tavsanKare + 9;
                        }

                        else if (T == 5)
                        {
                            Console.WriteLine("12 sola");
                            tavsanKare = tavsanKare - 12;
                            if (tavsanKare < 1)
                                tavsanKare = 1;
                        }

                        else if (T <= 8 && T >= 6)
                        {
                            Console.WriteLine("1 saga");
                            tavsanKare = tavsanKare + 1;
                            if (tavsanKare > 70)
                                tavsanKare = 70;
                        }

                        else if (T <= 10 && T >= 9)
                        {
                            Console.WriteLine("2 sola");
                            tavsanKare = tavsanKare - 2;
                            if (tavsanKare < 1)
                                tavsanKare = 1;
                        }
                        Console.WriteLine("Tavsan " + tavsanKare + ". karede");

                        /* YOL */
                        if (kaplumbagaKare < tavsanKare)
                        {
                            for (int i = 0; i < kaplumbagaKare - 1; i++)
                            {

                                Console.Write("_");
                            }

                            Console.Write("K");

                            for (int i = 0; i < tavsanKare - kaplumbagaKare - 1; i++)
                            {
                                Console.Write("_");
                            }

                            Console.Write("T");

                            for (int i = 0; i < 70 - tavsanKare; i++)
                            {
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");

                        }

                        else if (kaplumbagaKare > tavsanKare)
                        {
                            for (int i = 0; i < tavsanKare - 1; i++)
                            {
                                Console.Write("_");
                            }

                            Console.Write("T");

                            for (int i = 0; i < kaplumbagaKare - tavsanKare - 1; i++)
                            {
                                Console.Write("_");
                            }

                            Console.Write("K");

                            for (int i = 0; i < 70 - kaplumbagaKare; i++)
                            {
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");

                        }

                        else
                        {
                            for (int i = 0; i < tavsanKare - 1; i++)
                            {
                                Console.Write("_");
                            }
                            Console.Write("OUCH");

                            for (int i = 0; i < 67 - tavsanKare; i++)
                            {
                                Console.Write("_");
                            }
                            Console.WriteLine("\n");
                        }
                    }

                    /* SONUC */
                    if (kaplumbagaKare > tavsanKare)
                    {
                        Console.Write("\t\t      KAPLUMBAGA KAZANDI!!! OLEY!!\n\n");
                    }
                    else if (tavsanKare > kaplumbagaKare)
                    {
                        Console.Write("\t\t         TAVSAN KAZANDI . YUH\n\n");
                    }
                    else
                    {
                        Console.Write("\t\t        BERABERE\n\n");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (secim == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatali secim. Tekrar deneyin...\n");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}