Console.WriteLine("Kamp İntro!");
//array = dizi
string[] kurslar = new string[] {"x",
"y",
"z" };
for (int i = 0; i<kurslar.Length; i++ )
{
    Console.WriteLine(kurslar[i]);}
Console.WriteLine("Sayfa sonu - Footer");

//array dizi yazımı
string[] ürünler = new string[] {"elma",
    "armut",
    "kavun","patlıcan","karpuz"};
for (int i = 0;i < ürünler.Length;i++ )//length yazınca aralıkta ne kadar ürün varsa yazdırıyor.
{
    Console.WriteLine(ürünler[i]);

}

//for each komutu da for un aynısını yaparr
Console.WriteLine("for bitti şimdi for each örneği tekrar ediyor!");
foreach (var ürün in ürünler)
{
    Console.WriteLine(ürün);
}
Console.WriteLine("Sayfa Sonu-footer");//dikkat et burayı döngüden sonra yazdık, döngü içerinde yazarsak her
//birinin sonuna sayfa sonu yazar.