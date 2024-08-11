using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) //peki ne ekleyecez ürün, Urun bunun tipi yani classı urun ise ürün
        {
            //bu ilk haliydi. Console.WriteLine("Sepete eklendi.");
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);//adamlar yarın dedi kihadi önüne tebrikler yazalım, otomatikman prograam.cs teki kodumuz da güngellendi.
        }
        //public void Ekle2(string urunAdi, string Aciklama, double fiyat) //ve sonra dediler ki sokadedide ekleyelim
        // buraya hemen alttaki gibi int şeklinde ekledik ama program cs deki tüm ürünler b imzaya uymayacak ve 
        //tek tek düzeltme gerekecek, bizim imza patladı,işte bu yüzden prop eklemeliyiz. yani urun bölümüne gidip bir
        //prop ekleriz. Bu olay: encapsulation
        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}
