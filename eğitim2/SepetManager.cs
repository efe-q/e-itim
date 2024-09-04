using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eğitim2
{
    class SepetManager
    {
        public void Ekle(Urun Urun)
        {
            Console.WriteLine($"Tebrikler! Sepete eklendi: { Urun.Adi}");
        }


        public void EKLE2(string urunAdi , string acikama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi: " + urunAdi);
        }
    }
}
