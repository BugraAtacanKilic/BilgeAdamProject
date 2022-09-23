using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
    abstract class Para
    {
      

        private string name;
        private double deger;
        private double ilkTutar;
        private double ilkParaHacim;
        private double ilkExtraHacim;


        public string Name { get => name; set => name = value; }
        public double Deger { get => deger; set => deger = value; }
        public double IlkTutar { get => ilkTutar; set => ilkTutar = value; }
        public double IlkParaHacim { get => ilkParaHacim; set => ilkParaHacim = value; }
        public double IlkExtraHacim { get => ilkExtraHacim; set => ilkExtraHacim = value; }
    }
}
