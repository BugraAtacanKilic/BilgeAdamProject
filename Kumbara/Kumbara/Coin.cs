using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
    abstract class Coin : Para
    {
      

        private double hacim;
        private double yükseklik;
        private double yaricap;
        private static double pi = 3.14;
        private double ekstraHacim;

        public double Hacim { get => hacim; set => hacim = value; }
        public double Yükseklik { get => yükseklik; set => yükseklik = value; }
        public double Yaricap { get => yaricap; set => yaricap = value; }
        public static double Pi { get => pi; }
        public double EkstraHacim { get => ekstraHacim; set => ekstraHacim = value; }

        public double HacimHesapla(double yükseklik,double yaricap)
        {
            double hacim = Pi * yaricap * yaricap * yükseklik;
            return hacim;
        }
        Random rastgelAt = new Random();
        void CoinAt()
        {
            HacimHesapla(Yaricap,Yükseklik);
            ekstraHacim = hacim * (rastgelAt.Next(25, 75)) / 100;
            IlkTutar += Deger;

        }
    }
}
