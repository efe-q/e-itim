using eğitim2;


namespace egitim2
{

    class program
    {

        static void Main(string[] args)
        {
            Urun Urun = new Urun();
            string Adi = "Elma";
            string Aciklama = "Amasya elması";
            var Fiyati = 15;
            string Menseyi = "Amasya";
            int StokAdedi = 34;

            string[] meyveler = new string[] { "Elma", "Karpuz", "Cilek" ,"Naneli Limolata" };

            Urun Urun1 = new Urun();
            Urun1.Adi = "Cilek";
            Urun1.Aciklama = "Cilek gibi cilek";
            Urun1.Fiyati = 15;           
            Urun1.Menseyi = "istanbul";
            Urun1.StokAdedi= 56;

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Aciklama = "kıpkırmızı karpuzlar";
            Urun2.Fiyati = 80;           
            Urun2.Menseyi = "Adana";
            Urun2.StokAdedi = 23;

            Urun Urun3 = new Urun();
            Urun3.Adi = "limolata";
            Urun3.Aciklama = "Naneli Limolata";
            Urun3.Fiyati = 38;       
            Urun3.Menseyi = "çin";
            Urun3.StokAdedi = 1;

            Urun Urun4 = new Urun();
            Urun4.Adi = "su";
            Urun4.Aciklama = "Hayat su";
            Urun4.Fiyati = 10;           
            Urun4.Menseyi = "İstanbul";
            Urun4.StokAdedi = 48; 

            Urun[] urunler = new Urun[] { Urun1, Urun2, Urun3, Urun4 };

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine(item.Menseyi);
                Console.WriteLine(item.Fiyati);  
                Console.WriteLine(item.StokAdedi);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("------------METOTLAR------------");

            SepetManager sepetManager = new SepetManager();
            //sepetManager.Ekle(Urun1);
            //sepetManager.Ekle(Urun2);
            //sepetManager.Ekle(Urun3);
            //sepetManager.Ekle(Urun4);



            sepetManager.EKLE2("Karpuz", "kıpkırmızı karpuzlar", 80, 23);
            sepetManager.EKLE2("Elma", "Amasya Elması ", 15 , 34);
            sepetManager.EKLE2("Çilek", "Cilek gibi cilek ", 15, 56);
            sepetManager.EKLE2("Limolata", "Naneli Limolata ", 38 ,1);
            sepetManager.EKLE2("Su", "Hayat su", 10 , 48);

            Console.ReadKey();


        }
    }
}
