using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " +urun.Adi);

        }

        public void Ekle2(string urunAdi, string urunTanıtım, double fiyati)
        {
            Console.WriteLine(urunAdi);
        }
    }
}
