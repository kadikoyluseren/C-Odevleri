//AD SOYAD : SEREN KADIKÖYLÜ
//ÖĞRENCİ NUMARASI : 16253037

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] vezirKonum = new char[8, 8];
            Random rnd = new Random();
            int a = rnd.Next(0, 8);
            int b = rnd.Next(0, 8);
            int i;
            int j;
            //Console.WriteLine("\n      ilk vezir "+(a + 1) + ". satır " + (b + 1) + ". sütunda");
            Console.WriteLine("\n\t\t8 VEZİR");
            Console.WriteLine("\n\t    0 1 2 3 4 5 6 7");
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    if (i == a && j == b)
                        vezirKonum[i, j] = 'V';
                    else if (i == a || j == b)
                        vezirKonum[i, j] = '*';
                    else if (i + j == a + b - 14)
                    {
                        if (i == a - 7 && j == b - 7)
                        { vezirKonum[i, j] = '*'; }
                        else
                        {
                            vezirKonum[i, j] = '-';
                        }
                    }
                    else if (i + j == a + b - 12)
                    {
                        if (i == a - 6 && j == b - 6)
                        { vezirKonum[i, j] = '*'; }
                        else
                        {
                            vezirKonum[i, j] = '-';
                        }
                    }
                    else if (i + j == a + b - 10)
                    {
                        if (i == a - 5 && j == b - 5)
                        { vezirKonum[i, j] = '*'; }
                        else
                        {
                            vezirKonum[i, j] = '-';
                        }
                    }
                    else if (i + j == a + b - 8)
                    {
                        if (i == a - 4 && j == b - 4)
                        {
                            vezirKonum[i, j] = '*';
                            ;
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b - 6)
                    {
                        if (i == a - 3 && j == b - 3)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b - 4)
                    {
                        if (i == a - 2 && j == b - 2)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b - 2)
                    {
                        if (i == a - 1 && j == b - 1)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b)
                        vezirKonum[i, j] = '*';

                    else if (i + j == a + b + 2)
                    {
                        if (i == a + 1 && j == b + 1)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b + 4)
                    {
                        if (i == a + 2 && j == b + 2)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b + 6)
                    {
                        if (i == a + 3 && j == b + 3)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b + 8)
                    {
                        if (i == a + 4 && j == b + 4)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b + 10)
                    {
                        if (i == a + 5 && j == b + 5)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b + 12)
                    {
                        if (i == a + 6 && j == b + 6)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '-';

                        }
                    }
                    else if (i + j == a + b + 14)
                    {
                        if (i == a + 7 && j == b + 7)
                        {
                            vezirKonum[i, j] = '*';
                        }
                        else
                        {
                            vezirKonum[i, j] = '*';
                        }
                    }
                    else
                    {
                        vezirKonum[i, j] = '-';
                    }
                }
            }

            for (int k = 0; k < 8; k++)
            {
                Console.Write("\t  " + k + "");
                for (int t = 0; t < 8; t++)
                {
                    Console.Write(" "+vezirKonum[k, t]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n '*' koyulan yerlere vezir yerleştiremezsiniz! ");
            Console.ReadLine();
        }
    }
}