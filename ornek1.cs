using System;

class Program
{
    static void Main()
    {
        //Ornek1();
        //Ornek2();
        //Ornek3();
        Ornek4();
        //Ornek25();
        //Ornek26();
        //Ornek27();
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

        Console.WriteLine("Ürün fiyatını giriniz:");
        double eskiFiyat = Convert.ToDouble(Console.ReadLine());

        double yeniFiyat = HesaplaYeniFiyat(eskiFiyat);

        Console.WriteLine("Yeni satış fiyatı: " + yeniFiyat.ToString("C2"));
    }

    static double HesaplaYeniFiyat(double eskiFiyat)
    {
        double yeniFiyat;

        if (eskiFiyat >= 100)
        {
            // %10 indirim
            yeniFiyat = eskiFiyat * 0.9;
        }
        else if (eskiFiyat <= 50)
        {
            // %5 zam
            yeniFiyat = eskiFiyat * 1.05;
        }
        else
        {
            // 50-100 arası fiyatlar değişmez
            yeniFiyat = eskiFiyat;
        }

        return yeniFiyat;
    }

    static void Ornek3(){
        /*Bir sınıfta bulunan 20 öğrencinin Matematik dersine ait notu, 50 ve üzeri alanlar 
        sınıfı geçmiş, 50 altı olanlar
        kalmıştır. Klavyeden girilen 20 öğrencinin notuna göre sınıfı 
        geçenlerin ve kalanların sayısını buldurarak
        ekrana yazdıran programın akış diyagramını yapınız*/
        
        int d = 1;
        int geçenler = 0;
        int kalanlar = 0;
        do {
            Console.WriteLine("Matematik Notlarını Giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            
            if (not <= 50) {
                kalanlar += 1;
            }else {
                geçenler += 1;
            }
            

            if (d == 6) {
                break;
            }

            d += 1;
        }while(true);

        Console.WriteLine("Geçen Öğrencilerin Sayısı: " + geçenler);
        Console.WriteLine("Kalan Öğrencilerin Sayısı: " + kalanlar);
    }

    static void Ornek4(){
        
       /* Bir daireye ait yarıçap bilgisi girilsin. Kullanıcıya dairenin alanını mı yoksa çevresini mi istediği sorulsun (Alan
        için “A” çevre için “Ç” seçilebilecek). Kullanıcının seçimine göre
         Alan yada Çevreyi bulup yazdıran bir programı
        switch /case ie yazınız. ( Çevre:2*Pi*r Alan:Pi*r*r */
        double Pi = 3.14;
        double alan,cevre;
        Console.WriteLine("Yarıçap Bilgisi Giriniz: ");
        int yaricap = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dairenin ALanı İçin(A) Çevresi İçin(Ç) Giriniz: ");
        string cevap = Console.ReadLine();
        
        switch(cevap) 
        {
        case "A":
            // Alan Bulunacak
            alan = Pi*yaricap*yaricap;
            Console.WriteLine("Dairenin Alanı: " + alan);
            break;
        case "Ç":
            // Yarıcap Bulunacak
            cevre = 2*Pi*yaricap;
            Console.WriteLine("Dairenin Çevresi: " + cevre);
            break;
        default:
            Console.WriteLine("Yanlış Değer");
            break;
        }

    }

    static void Ornek5(){
        /*𝐗 = 𝟐
        𝟏 + 𝟒
        𝟒 + 𝟔
        𝟗 + 𝟖
        𝟏𝟔 … . . … . + 𝟐𝐧
        𝐧𝟐 Dışarıdan girilen “n” değerine göre X değerini hesaplayıp ekrana
        yazan programı yazınız*/
        
    }

    static void Ornek6(){
        /* Klavyeden Negatif bir sayı girilene kadar, girilen öğrenci notlarını alarak, bunların ortalamasını bulan ve
        ekrana yazdıran programı gerçekleştiriniz.*/
        
    }

    static void Ornek7(){
        /* Klavyeden “0” sıfır girilinceye kadar girilen sayılardan en küçüğünü bulan programın akış diyagramını yapınız */
    }

    static void Ornek8(){
        /* Negatif bir sayı girilene kadar, klavyeden girilen öğrenci notlarını alarak, bunların ortalamasını ekrana yazdıran
        programı gerçekleştiriniz.*/
        
    }

    static void Ornek9(){
        /* Klavyeden “0-SIFIR” değeri girilene kadar GİRİLEN sayılar içinde, ASAL olan sayıların TOPLAMINI bulan ve bu
        toplamı ekrana yazdıran bir JAVA programı yazınız?*/
        
    }

    static void Ornek10(){
        /* “Devam etmek istiyor musunuz?” sorusuna “E” girildiği sürece klavyeden girilen sayılardan çift sayıları
        toplayan, tek sayıları çarpan ve sonuçları ekranda gösteren uygulamayı yazınız*/


    }

    static void Ornek11(){
         /*Klavyeden “0-SIFIR” değeri girilene kadar, girilen sayılardan KAREKÖKÜ’nün sonucu TAM SAYI olan sayıların
        adetini bulan ve ekrana yazdıran programı Java ‘da yazınız?
        (Örnek: 9’un karekökü 3’tür ve tam sayıdır , 8 ‘in karakökü 2.82.. dir ve tam sayı değildir.)

        Math.sqrt(sayi)  Sayının karekökünü alır.
        Math.floor(sayi) Sayının tam kısmını alır. Sayıyı aşağıya yuvarlar
    
        İPUCU: 123%10 işleminde kalan 3 dür.123/10 işleminde sonuç 12 dir*/
        
    }

    static void Ornek12(){
        /* Klavyeden girilen integer bir sayının basamaklarındaki rakamların alt alta 
        yazdıran bir program yazınız.*/
    }

    static void Ornek13(){
        /* Klavyeden girilen integer bir sayının basamak sayısını hesaplayan bir program yazınız.*/      
        
    }

    static void Ornek14(){
        /*  Klavyeden girilen integer bir sayının basamaklarındaki rakamların toplamını bulan bir program yazınız.
        Örnek: 1234  1+2+3+4=10*/
        
    }

    static void Ornek15(){
        /* Klavyeden girilen bir sayının basamak değerlerindeki rakamlardan tek sayı olanların toplamını bulan ve
        ekrana yazdıran programı yazınız.
        (Örnek:62176948 sayısında 1,7 ve 9 tek sayıdır ve toplamı 17 dir */
    }

    static void Ornek16(){
        /*  Klavyeden girilen int tipindeki “sayi” ve “rakam” değerlerine göre, sayi içerisindeki bu rakamın sayısını
        bulduran programı yazınız.
        Örnek = sayı=122425 rakam=2122425 sayısı içerisindeki 2 rakamının adeti 3 dü*/
    }

    static void Ornek17(){
        /*  Klavyeden girilen bir sayının kaç tane tam böleninin olduğunu bularak ekrana yazdıran programı
        gerçekleştiriniz.*/
    }

    static void Ornek18(){
        /* Klavyeden girilen bir sayının (“kendisi” ve “1” hariç) tam bölenlerinin toplamını bularak ekrana yazdıran
        programı c# programlama dilinde yazınız.*/
    }

    static void Ornek19(){
        /* Klavyeden girilen bir sayının mükemmel bir sayı olup olmadığını bulan bir program yazınız. (Mükemmel sayı
        kendisi hariç bölenlerinin toplamı kendisine eşit olan sayıdır. Örnek: 6’nın kendisi hariç bölenleri toplamı
        
        1+2+3=6 dır ve 6 mükemmel sayıdır.*/

    }

    static void Ornek20(){
        /* Klavyeden girilen bir sayının asal olup olmadığını bulduran programı yazınız?*/
    }

    static void Ornek21(){
        /* Klavyeden girilen bir sayıyı ikili (binary) sayı sistemine çeviriniz*/
        
    }

    static void Ornek22(){
        /* PUCU: Programlama dillerinde (Java, C# vs)string işlemleri araştırınız.
        String H=”ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ”;
        22. Klavyeden girilen sayı kadar rastgele harflerden oluşan bir şifre oluşturunuz. (klavyeden 5 girildiğinde 5 harflik
        bir şifre (TEYFJ)*/
        
    }

    static void Ornek23(){
        /* lavyeden girilen satır ve sütun sayısına göre rastgele rakamlardan oluşan
        matrisi ekrana yazdıran programı yazınız*/
        
    }

    static void Ornek24(){
        /* Klavyeden girilen satır ve sütun sayısına göre rastgele harflerden oluşan
        matrisi ekrana yazdıran programı yazını*/
        
    }

    static void Ornek25(){
        /* Klavyeden 0 girilinceye kadar girilen sayıların toplamını bulan program */
        int toplam = 0;
        while(true) {
            Console.WriteLine("Sayı Gir: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 0) {
                break;
            }else {
                toplam += sayi;
            }
        }
        Console.WriteLine("Toplam Değer: " + toplam);
    }

    static void Ornek26(){
        /* Klavyeden negatif bir sayı girilinceye kadar girilen sayılardan tek sayılarını bulan program */
        int teksayilar = 0;
        while(true) {
            Console.WriteLine("Sayı Gir: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi <= 0) {
                break;
            }else if (sayi % 2 == 1){
                teksayilar += 1;
            }
        }
        Console.WriteLine("Tek Sayılar: " + teksayilar);
    }


    static void Ornek27(){
        /*  */
       
    }


}
