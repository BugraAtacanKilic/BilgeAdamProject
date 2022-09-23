using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241121PersonelKayitOtomasyonu
{
    class Personel
    {
        //•	Personel id 5 basamaklı bir sayı olmalıdır.
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                //if (value >= 10000 && value <= 99999)
                //{
                //    _id = value;
                //}
                //else 
                //{
                //    throw new Exception("Id değeri 5 basamaklı bir sayı olmalıdır");
                //}

                if (value < 10000 || value > 99999)
                {
                    throw new Exception("Id değeri 5 basamaklı bir sayı olmalıdır");
                }
                _id = value;
            }
        }

        //•	Ad soyad 2 karakterden fazla ve baş harfi büyük harf sonraki harfler küçük olmalıdır.Değilse bile kayıt bu formata uygun yapılmalıdır.
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Ad değeri en az iki karakter olmalıdır");
                }
                _ad = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        private string _soyad;
        public string Soyad
        {
            get { return _soyad; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Ad değeri en az iki karakter olmalıdır");
                }
                _soyad = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        //•	Çalışanlar 18 yaşından küçük olamazlar.
        private DateTime _dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                if (value.AddYears(18) > DateTime.Now)
                {
                    throw new Exception("Çalışan 18 yaşından büyük olmalıdır.");
                }
                _dogumTarihi = value;
            }
        }

        //•	Telefon Numarasında 10 rakam bulunmak zorundadır.Maskeleme yapılabilir.
        private string _telNo;

        public string TelNo
        {
            get { return _telNo; }
            set
            {
                string numbers = value.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                if (numbers.Length != 10)
                {
                    throw new Exception("Telefon Numaranızı lütfn kontrol edin");
                }
                _telNo = numbers;
            }
        }

        //•	E-mail içerinde mutlaka @ bulunmalı ve mail adresi .com ile bitmelidir.
        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@") || !value.EndsWith(".com"))
                {
                    throw new Exception("Email formatına uygun değildir.");
                }
                _email = value;
            }
        }

        //•	Adres en az 100 karakter olmalıdır.
        private string _adres;

        public string Adres
        {
            get { return _adres; }
            set
            {
                if (value.Length < 10)
                {
                    throw new Exception("Adres uzunluğu 10 karakterden fazla olmalıdır");
                }
                _adres = value;
            }
        }

        //•	İşe giriş tarihi bugün veya bugünden önceki bir tarih olmalıdır.
        private DateTime _iseGirisTarihi;

        public DateTime IseGirisTarihi
        {
            get { return _iseGirisTarihi; }
            set
            {
                if (value >= DateTime.Now)
                {
                    throw new Exception("Ise Giriş Tarihi şu andan önceki bir tarih olmalıdır");
                }
                _iseGirisTarihi = value;
            }
        }

        //•	Bilgisayardan resim seçilebilmelidir.
        public string FotoYolu { get; set; }
        public Unvan Unvan { get; set; }
    }
}
