// type safety = tip güvenliği

using System;

class Program
{
    static void Main()
    {
        string Adi = "Efe";
        int Yas = 19;

        kurs kurs1 = new kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "efe";
        kurs1.IzlenmeOrani = 68;

        kurs kurs2 = new kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "mehmet";
        kurs2.IzlenmeOrani = 12;

        kurs kurs3 = new kurs();

        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Asya";
        kurs3.IzlenmeOrani = 13;

        kurs kurs4 = new kurs();

        kurs4.KursAdi = "c++";
        kurs4.Egitmen = "gülşah";
        kurs4.IzlenmeOrani = 100;
        kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4};

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);


        }
    }

}

class kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}






