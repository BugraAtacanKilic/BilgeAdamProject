using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara.Paralar
{
    class BesKurus:Coin
    {
        public BesKurus()
        {
            Name = "Beş Kuruş";
            Deger = 0.05;
            Yaricap = 1.75;
            Yükseklik = 0.165;
            HacimHesapla(Yaricap , Yükseklik);
            
        }
        //Geri Kalan Kuruşlarda Aynı Şekilde.
    }
}
