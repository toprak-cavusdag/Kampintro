using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi ="Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stockAdedi = 200;


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyabakır Karpuzu";
            urun2.stockAdedi = 120;


            Urun[] urunler = new Urun[] { urun1,urun2};


            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");

            }

            Console.WriteLine("-------------METODLAR------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Elma", 12);
            sepetManager.Ekle2("Elma", "Amasya Elması", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Elma", 12);
        }
    }
}
