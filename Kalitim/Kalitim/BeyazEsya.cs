using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public abstract class BeyazEsya // "public abstract class" bu nesneyi oluşturmamızı engeller bu sayede bu sınıf sadece base class olarak kullanılabilir. Bağımsız veri girişini engeller.
        //Yalnızca bağlı olduğu sınıflarla birlikte kullanılabilir.Yalnızca sınıflarda kullanılabilir.Ayrıca sınıfın yalnızca kalıtım yapılması için kullanılır.
    {
        public BeyazEsya() { }
        public BeyazEsya(string Isim, string Marka, double Fiyat)
        {
            this.Isim = Isim;
            this.Marka = Marka;
            this.Fiyat = Fiyat;
        }
        public string Isim { get; set; }
        public string Marka { get; set; }
        public double Fiyat { get; set; }
    }
}
