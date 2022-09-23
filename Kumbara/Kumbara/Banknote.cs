using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
    class Banknote:Para
    {
        private double _en;
        private double _boy;
        private double _yukseklik;
        private double _hacim;
        private double _ekstraHacim;
        private bool _paraKatlanDimi;

     

        public double En { get => _en; set => _en = value; }
        public double Boy { get => _boy; set => _boy = value; }
        public double Yukseklik { get => _yukseklik; set => _yukseklik = value; }
        public double Hacim { get => _hacim; set => _hacim = value; }
        public double EkstraHacim { get => _ekstraHacim; set => _ekstraHacim = value; }
        public bool ParaKatlanDimi
        {
            get
            {

                if (_paraKatlanDimi == false)
                {
                    throw new Exception("Kağıt parayı katlanmadan kumbaraya atmayınız. ");
                }
                else
                {
                    return _paraKatlanDimi;
                }
            }
            set
            {
                if (value == true)
                {
                    throw new Exception("Kağıt parayı zaten katlandınız");
                }
                _paraKatlanDimi = value;
            }
        }
        
        public double HacimHesapla(double _en,double _boy,double _yukseklik)
        {
            double _hacim = (_en / 4) * _boy * (_yukseklik * 4);
            return _hacim;
        }
        Random rastgeleAt = new Random();
        public void BanknoteAt()
        {
            if (ParaKatlanDimi == true)
            {
                HacimHesapla(En, Boy, Yukseklik);
                _ekstraHacim = Hacim * (rastgeleAt.Next(25, 75)) / 100;
                IlkExtraHacim = IlkParaHacim + _ekstraHacim;
               //Nasıl eşitlemem gerektiğini bulamadım hacimlerin?İlk tuttuğumuz hacimle eklenen hacimlerin



            }
        }

    }
}
