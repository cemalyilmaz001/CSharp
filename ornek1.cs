using System;

class Program
{
    static void Main()
    {
        //Ornek1();
        Ornek2();
    }

    static void Ornek1() {
        // Klavyeden girilen satış tutarına göre 1000 tl altında ise %10, 1000tl ve 2000tl 
        // arası ise %15, 2000tl üzeri ise
        // %20 iskonto uygulayan ve bu tutar üzerinden %18 kdv ekleyip ödenecek tutarı yazan 
        // programı gerçekleştiriniz
        
        // Kullanıcıdan satış tutarını al
        Console.Write("Satış Tutarını Girin: ");
        double satisTutari = Convert.ToDouble(Console.ReadLine());

        // İskonto oranını belirle
        double iskontoOrani;
        if (satisTutari < 1000)
        {
            iskontoOrani = 0.10;
        }
        else if (satisTutari >= 1000 && satisTutari <= 2000)
        {
            iskontoOrani = 0.15;
        }
        else
        {
            iskontoOrani = 0.20;
        }

        // İskonto uygula
        double iskontoluTutar = satisTutari - (satisTutari * iskontoOrani);

        // KDV ekleyip toplam tutarı hesapla
        double kdvOrani = 0.18;
        double odenecekTutar = iskontoluTutar + (iskontoluTutar * kdvOrani);

        // Sonucu ekrana yazdır
        Console.WriteLine($"İskonto Uygulanan Tutar: {iskontoluTutar:C}");
        Console.WriteLine($"Ödenecek Tutar (KDV Dahil): {odenecekTutar:C}");

    }

    static void Ornek2(){
        
        // Bir market 100 tl ve üzerindeki ürünlerinde %10 indirim yaparken, 
        // 50 tl ve altındaki ürünlerine de %5 zam
        // yapacaktır. Aradaki ürünlerin (50 ve 100 tl arası) fiyatlarında değişiklik olmayacaktır. 
        // Eski fiyat girildiğinde yeni
        // satış fiyatını hesaplayan ve ekrana yazan programı gerçekleştiriniz
        
        

    }

}
