using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BeyazEsya esya = new BeyazEsya();
            //esya.Isim = "Deneme";
            //esya.Marka = "Deneme";
            //esya.Fiyat = 50;


            //*** Her sınıf Isim, Marka, Fiyat bilgisini Beyaz eşyadan kalıtım yaptı ***//

            CamasirMakinesi cm = new CamasirMakinesi();
            cm.Marka = "SIEMENS";
            cm.ProgramSayisi = 3;
            cm.Kurutma = true;
            cm.Isim = "SM-23";
            cm.Fiyat = 55000;

            BulasikMakinesi bm = new BulasikMakinesi();
            bm.Marka = "ARCELİK";
            bm.EnerjiSinifi = "A++";
            bm.KisiSayisi = 10;
            bm.Isim = "AC-53";
            bm.Fiyat = 34000;

            List<BeyazEsya> esyalar = new List<BeyazEsya>();
            esyalar.Add(cm);
            esyalar.Add(bm);

            for (int i = 0; i < esyalar.Count; i++)
            {
                Console.WriteLine($"{esyalar[i].Marka} {esyalar[i].Isim} {esyalar[i].Fiyat}"); //Burada BeyazEsya sınıfından bir liste yaptığımız için sadece BeyazEsya sınıfından kalıtım yaptığımız verileri çekebiliyoruz.
            }
        }
    }
}
