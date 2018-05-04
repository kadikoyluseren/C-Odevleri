
// AD SOYAD : SEREN KADIKÖYLÜ
// ÖĞRENCİ NUMARASI : 16253037

using System;
namespace HW3_16253037
{
    class Dikdortgen
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dikdortgen()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Dikdortgen(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        private int en;
        private int boy;
        public int En
        {
            get
            {
                return en;
            }
            set
            {
                if (value > 0)
                    en = value;

            }
        }
        public int Boy
        {
            get
            {
                return boy;
            }
            set
            {
                if (value > 0)
                    boy = value;
            }
        }

        public int Alan()
        {
            return en * boy;
        }

        public int Cevre()
        {
            return 2 * (en + boy);
        }

        public void Hareket(int xx, int yy)
        {
            X = X + xx;
            Y = Y + yy;
            Console.WriteLine("\n"+xx+ " BIRIM X, " + yy+ " BIRIM Y DOGRULTUSUNDA HAREKET SONUCU KOSE KOORDINATLARI");
        }
        
        public void KoordinatYazdir()
        {
            Console.WriteLine(String.Format("{0,-9}{1,9}", "(" + X + "," + (Y + boy) + ")", "(" + (X + en) + "," + (Y + boy) + ")"));
            Console.WriteLine(String.Format("{0,-9}{1,9}", "(" + X + "," + Y + ")", "(" + (X + en) + "," + Y + ")"));
        }

        public void CevreAlanYazdir()
        {
            Console.WriteLine("\nCevre = " + Cevre());
            Console.WriteLine("Alan = " + Alan());
        }

    }
}
