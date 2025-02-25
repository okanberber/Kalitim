using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class CamasirMakinesi : BeyazEsya
    {
        public CamasirMakinesi() { } // Default Constuctor
        public CamasirMakinesi(string isim, string marka, double fiyat, int programSayisi, bool kurutma) // Yapıcı metot bu sayede program başlatıldığı anda verileri belirtilen yerlere işler.
        {
            base.Isim = isim;
            base.Marka = marka;
            base.Fiyat = fiyat;
            this.ProgramSayisi = programSayisi;
            this.Kurutma = kurutma;
        }
        // c# Çoklu kalıtım kabul etmez.Bir sınıf sadece bir sınıftan kalıtım alabilir.
        public int ProgramSayisi { get; set; }
        public bool Kurutma { get; set; }
    }
}
