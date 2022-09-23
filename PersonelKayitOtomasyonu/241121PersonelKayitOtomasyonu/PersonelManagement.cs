using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace _241121PersonelKayitOtomasyonu
{
    static class PersonelManagement
    {
        static public void Serialize(List<Personel> personeller)
        {
            var _options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string _jsonData = JsonSerializer.Serialize(personeller,_options); //var olan List<Personel> i json formatına dönüştür stringe ata
            File.WriteAllText(@"C:\Users\gizem.iseri\Desktop\241121PersonelKayitOtomasyonu\241121PersonelKayitOtomasyonu\personeller.json", _jsonData);
        }
        static public List<Personel> DeSerialize()
        {
            //json dosyasından string oku 
            string json = File.ReadAllText(@"C:\Users\gizem.iseri\Desktop\241121PersonelKayitOtomasyonu\241121PersonelKayitOtomasyonu\personeller.json");
            //json formatındaki string datayı List<Personel> formatına çevir
            List<Personel> _deserilazeUserList = JsonSerializer.Deserialize<List<Personel>>(json);
            return _deserilazeUserList;
        }

        //NewtonSoft
    }
}
