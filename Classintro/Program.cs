using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //string ad = "Toprak";
            //int yas = 19;


            kurs kurs1 = new kurs();
            kurs1.kursAdı = "C#";
            kurs1.Egitmen = "Toprak CAVUSDAG";
            kurs1.izlenmeOranı = 98;


            kurs kurs2 = new kurs();
            kurs2.kursAdı = "JAVA";
            kurs2.Egitmen = "Kadir CAVUSDAG";
            kurs2.izlenmeOranı = 78;

            Console.WriteLine(kurs1.kursAdı + " " + kurs1.Egitmen + " " + kurs1.izlenmeOranı);
            Console.WriteLine(kurs2.kursAdı + " " + kurs2.Egitmen + " " + kurs2.izlenmeOranı);

            Console.WriteLine();

            kurs[] kurslar = new kurs[] { kurs1, kurs2 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdı + " " + kurs.Egitmen);
            }

           
        }
    }

    class kurs
    {
        public string kursAdı { get; set; }

        public string Egitmen { get; set; }

        public int izlenmeOranı { get; set; }
    }
}
