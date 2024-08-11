internal class Program
{
    private static void Main(string[] args)
    {
        string adi = "Engin";
        int yas = 36;

        ürün ürün1 = new ürün();
        ürün1.ürünadi = "armut";
        ürün1.ürünsinifi = "Narenciye";
        ürün1.alinmaorani = 10;
        ürün1.ürünmensei = "iran";

        ürün ürün2 = new ürün();
        ürün2.ürünadi = "elma";
        ürün2.ürünsinifi = "meyve";
        ürün2.alinmaorani = 8;
        ürün2.ürünmensei = "tr";

        ürün ürün3 = new ürün();
        ürün3.ürünadi = "kabak";
        ürün3.ürünsinifi = "sebze";
        ürün3.alinmaorani = 10;
        ürün3.ürünmensei = "irak";

        //Console.WriteLine(ürün1.ürünadi + " " + ürün1.ürünsinifi + " " + +ürün1.alinmaorani + " " + ürün1.ürünmensei);
        //Kurs array tanımlıyoruz aşağıda
        ürün[] ürünler = new ürün[] {ürün1, ürün2,  ürün3 };

        foreach (var ürün in ürünler)
            //var olduğunda veri hangi tipteyse onu kullanır böylece str yada int vs yazmayız.
        {
            Console.WriteLine(ürün.ürünadi + " " + ürün.ürünsinifi); //burda foreach ile tamamen sadece ürün adlarını döndük
        }

        Console.WriteLine("Hello, World!");
    }
}

class ürün
{
    public string ürünadi { get; set; }
    public string ürünmensei { get; set; }
    public string ürünsinifi { get; set; }
    public int alinmaorani { get; set; }
}