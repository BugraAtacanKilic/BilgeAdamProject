using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara.Paralar
{
    class BesLira:Banknote
    {
        public BesLira()
        {
            Name = "Beş Lira";
            Deger = 5;
            En = 6.4; 
            Boy = 13;
            Yukseklik = 0.025; 
            ParaKatlanDimi = false;
            HacimHesapla(En, Boy, Yukseklik);
        }
        //Geri Kalan Liralarda Aynı şekilde.
    }
}
