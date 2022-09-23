using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
    class Kumbara:Para
    {
      

        private const double _kumbaraToplamHacmi = 100;

        private double _kumbaraİlkHacmi;
        private double _kumbaraİlkTutar;

        


        public static double KumbaraToplamHacmi => _kumbaraToplamHacmi;

        public double KumbaraİlkHacmi { get => _kumbaraİlkHacmi; set => _kumbaraİlkHacmi = value; }
        public double KumbaraİlkTutar { get => _kumbaraİlkTutar; set => _kumbaraİlkTutar = value; }
        

        public void Control()
        {
            KumbaraİlkHacmi = IlkParaHacim + IlkExtraHacim;

            if (KumbaraİlkHacmi <= _kumbaraToplamHacmi)
            {
                Console.WriteLine("Kumbara dolmuş");
            }
        }
        public double Shake()
        {
            KumbaraİlkHacmi = IlkParaHacim * 1.25;

            return KumbaraİlkHacmi;
        }
        //Kırılıp Tekrar Yapıştırmayı Bulamadım
    }

}
