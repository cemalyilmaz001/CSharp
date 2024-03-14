using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        //Ornek1();
        //Ornek2();
        //Ornek3();
        //Ornek4();
        //Ornek25();
        //Ornek26();
        //Ornek27();
        //Ornek7();
        //Ornek8();
        //Ornek9();
        //Ornek10();
        //Ornek20();
        //NesneYönelimÖrnek1();
        //NesneYönelimÖrnek2();
        //NesneYönelimÖrnek3();
        //NesneYönelimÖrnek4();
        //NesneYönelimÖrnek5();

        while(true) {

            Console.Write(
@"=============================
Nesne Tab Prog Lab Çal Soru_2
=============================
1) Dizilerdeki Tek ve Çift Sayıları Bulan
2) Dizilerdeki Pozitif Sayıları Bulan
3) Dizilerdeki En Büyük Değeri Bulan
4) Dizi Ortalamasının En Büyük ve En Küçük Değeri
5) İndis Numarası Çift Olan Değerler
=============================
Nesne Tab Prog Lab Çal Soru_3
=============================
6) Decimal den Binray ye çevirme 
7) Çalışma Sorusu 2
8) Kura İşlemi
9) Sayısal Loto
10)Adisyon Programı 
=============================
Object Oriented Programing
=============================
11) Örnek 1
12) Faktoriyel Hesaplama
13) Harf Bulma
14) Kelime Bulma
15)
16)
17)
18)
19)
20)
=============================
99)Exit

Hangi Numarayı çalıştırmak istersin: ");

            try { 
                int kontrol = Convert.ToInt32(Console.ReadLine());
                switch(kontrol)
                {
                case 1:
                    NesneYönelimÖrnekArraylerÖrnekleri1();
                    Console.ReadKey();
                    clear();
                    continue;
                case 2:
                    NesneYönelimÖrnekArraylerÖrnekleri2();
                    Console.ReadKey();
                    clear();
                    continue;
                case 3:
                    NesneYönelimÖrnekArraylerÖrnekleri3();
                    Console.ReadKey();
                    clear();
                    continue;
                case 4:
                    NesneYönelimÖrnekArraylerÖrnekleri4();
                    Console.ReadKey();
                    clear();
                    continue;
                case 5:
                    NesneYönelimÖrnekArraylerÖrnekleri5();
                    Console.ReadKey();
                    clear();
                    continue;
                case 6:
                    DecimalBinaryTranslate();
                    Console.ReadKey();
                    clear();
                    continue;
                case 7:
                    NesneYönelimÖrnekArraylerÖrnekleri6();
                    Console.ReadKey();
                    clear();
                    continue;
                case 8:
                    KuraSayacV1();
                    Console.ReadKey();
                    clear();
                    continue;
                case 9:
                    SayisalLoto();
                    Console.ReadKey();
                    clear();
                    continue;
                case 10:
                    NesneYönelimÖrnekArraylerÖrnekleri7();
                    Console.ReadKey();
                    clear();
                    continue;
                case 11:
                    NesneYönelimÖrnekleri();
                    Console.ReadKey();
                    clear();
                    continue;
                case 99:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Yanlış Değer");
                    Console.ReadKey();
                    clear();
                    continue;
                }
            }
            catch (FormatException)
            {
                // Format hatası olduğunda çalışacak kodlar catch bloğuna yazılır
                Console.WriteLine("Hatalı format! Lütfen sayı giriniz.");
            }
            catch (OverflowException)
            {
                // Taşma hatası olduğunda çalışacak kodlar catch bloğuna yazılır
                Console.WriteLine("Çok büyük bir sayı girdiniz.");
            }
            finally
            {
                // Her durumda çalışacak kodlar finally bloğuna yazılır
                Console.WriteLine("Program sonlandırıldı.");
            }

        }
        

    }

    static void clear() {
        // Linux'ta "clear" komutunu çalıştır
        Process process = new Process();
        process.StartInfo.FileName = "/bin/bash";
        process.StartInfo.Arguments = "-c \"clear\"";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.Start();

        // Çıktıyı oku ve ekrana yazdır
        string output = process.StandardOutput.ReadToEnd();
        Console.WriteLine(output);

        process.WaitForExit();
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

    static void Ornek7()
    {
        /* Klavyeden “0” sıfır girilinceye kadar girilen sayılardan en küçüğünü bulan programın akış diyagramını yapınız */
        int enkucuksayi = 0;

        Console.WriteLine("Sayı giriniz: ");
        int sayiilk = Convert.ToInt32(Console.ReadLine());

        while (sayiilk != 0)
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < enkucuksayi || enkucuksayi == 0)
            {
                enkucuksayi = sayi;
            }

            if (sayi == 0)
            {
                break;
            }
        }

        Console.WriteLine("En küçük sayı: " + enkucuksayi);
        Console.ReadKey();
    }


    static void Ornek8(){
        /* Negatif bir sayı girilene kadar, klavyeden girilen öğrenci notlarını alarak, bunların ortalamasını ekrana yazdıran
        programı gerçekleştiriniz.*/
        int ortalama = 0;
        int adet = 0;
        int sonuc = 0;
        do {
            Console.WriteLine("Not Giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            ortalama += not;
            adet += 1;
            if(not < 0) {
                break;
            } 
        }while(true);
        sonuc = ortalama / adet;
        Console.WriteLine("Girilen Notların Ortalaması: " + sonuc);
    }

    static void Ornek9(){
        /* Klavyeden “0-SIFIR” değeri girilene kadar GİRİLEN sayılar içinde, ASAL olan sayıların TOPLAMINI bulan ve bu
        toplamı ekrana yazdıran bir Csharp programı yazınız?*/

        int toplam = 0;
        do {
            Console.WriteLine("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            if(sayi == 2){
                if(sayi % 2 == 0){
                    toplam += sayi;
                }
            }

            if(sayi % 2 == 1) {
                // Asal Sayi
                toplam += sayi;
            }

            if(sayi == 0) {
                break;
            }
        }while(true);
        
        Console.Write(toplam);
        
    }

    static void Ornek10(){
        /* “Devam etmek istiyor musunuz?” sorusuna “E” girildiği sürece klavyeden girilen sayılardan çift sayıları
        toplayan, tek sayıları çarpan ve sonuçları ekranda gösteren uygulamayı yazınız*/
        int teksayilarin_toplamı  = 0;
        int çiftsayilarin_toplamı = 0;
        do {
            Console.Write("Sayi Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi % 2 == 0) {
                çiftsayilarin_toplamı += sayi;
            }else {
                teksayilarin_toplamı += sayi;
            } 

            Console.Write("Devam etmek istiyor musunuz? ('E','H'): ");
            string devam = Console.ReadLine();
            if(devam == "H"){
                break;
            }
        }while(true);
        
        if (çiftsayilarin_toplamı != 0){
            Console.WriteLine("Çift Sayıların Toplamı: " + çiftsayilarin_toplamı);
        }

        if (teksayilarin_toplamı != 0){
            Console.WriteLine("Tek Sayıların Toplamı: " + teksayilarin_toplamı);
        }
    
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
        
         Console.WriteLine("Bir sayı girin:");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} bir asal sayıdır.");
            }
            else
            {
                Console.WriteLine($"{number} bir asal sayı değildir.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girişi yaptınız.");
        }


    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
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
        /* klavyeden girilen satır ve sütun sayısına göre rastgele rakamlardan oluşan
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
        /* random ile rasgele bir değer oluşturma ve 5 denemede bulma oyunu  */
       
        


    }


    static void NesneYönelimÖrnek1(){
        //Klavyeden girilen bir metin içinde yine klavyeden girilen bir harfin sayısını ve konumlarını bulduran programı yazınız

        Console.WriteLine("Bir metin giriniz:");
        string metin = Console.ReadLine();

        Console.WriteLine("Bir harf giriniz:");
        Char karakter = Console.ReadKey().KeyChar;

        List<int> konumlar = new List<int>();
        int sayi = 0;

        for (int i = 0; i < metin.Length; i++) {
            if (metin[i] == karakter)
            {
                sayi++;
                konumlar.Add(i);
            }
        }
        Console.WriteLine("\n\nKarakter '{0}' metinde {1} kez bulundu.", karakter, sayi);
        Console.WriteLine("Karakterin konumları: " + string.Join(", ", konumlar));
    }



    static void NesneYönelimÖrnek2() {
        // 2)Klavyeden girilen bir metindeki harfleri ve harf indexsini alt alta listeleyiniz.
        Console.WriteLine("Bir metin giriniz:");
        string metin = Console.ReadLine();

        for (int i = 0; i < metin.Length; i++) {
            Console.WriteLine(i + ". Harf " + metin[i]);
        }
    }
    
    static void NesneYönelimÖrnek3(){
        // 3) Klavyeden girilen bir metinin baş harflerini ekrana yazdırınız.
        Console.WriteLine("Bir metin giriniz:");
        string metin = Console.ReadLine();
        char ilkHarf = metin[0];
        Console.Write(ilkHarf);
    }

    static void NesneYönelimÖrnek4() {
        // Klavyeden girilen bir metin içerisindeki bir ifadeyi (metin harf karakter vs.) yine klavyeden girilen bir ifade (metin harf 
        // karakter vs.) ile değiştiren programı yazınız
        
        Console.Write("Lütfen bir metin giriniz: ");
        string metin = Console.ReadLine();

        Console.Write("Değiştirilecek ifadeyi giriniz: ");
        string eskiIfade = Console.ReadLine();

        Console.Write("Yeni ifadeyi giriniz: ");
        string yeniIfade = Console.ReadLine();

        string sonuc = metin.Replace(eskiIfade, yeniIfade);

        Console.WriteLine("Sonuç: " + sonuc);
    }

    static void NesneYönelimÖrnek5() {
        // Klavyeden girilen bir kelimeyi tersten yazan programı yazınız

        Console.Write("Lütfen bir metin giriniz: ");
        string metin = Console.ReadLine();

        char[] charArray = metin.ToCharArray();
        Array.Reverse(charArray);
        string tersMetin = new string(charArray);

        Console.WriteLine("Metnin ters çevrilmiş hali:");
        Console.WriteLine(tersMetin);
    }


    static void NesneYönelimÖrnekArraylerÖrnekleri1() {
        
        // 10 elemanlı bir dizi içerisinde rasgele (1-100 aralığında)
        // sayılar atılacak bu dizideki tek ve çift sayıların toplamını 
        // bulan ve yazdıran programı yazınız

        Random random = new Random();
        int[] dizi = new int[10];
        int tekToplam = 0, ciftToplam = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = random.Next(1, 101);
            Console.WriteLine($"Dizinin {i+1}. elemani: {dizi[i]}");

            if (dizi[i] % 2 == 0)
            {
                ciftToplam += dizi[i];
            }
            else
            {
                tekToplam += dizi[i];
            }
        }

        Console.WriteLine($"Dizideki tek sayıların toplamı: {tekToplam}");
        Console.WriteLine($"Dizideki çift sayıların toplamı: {ciftToplam}");

    }


    static void NesneYönelimÖrnekArraylerÖrnekleri2() {
        // 10 elemanlı bir dizi içerisinde klavyeden sayılar girilecektir 
        // bu dizideki pozitif sayıların toplamını bulan ve yazdıran 

        int[] dizi = new int[10];
        int toplam = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Sayı girin: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
            if (dizi[i] > 0)
            {
                toplam += dizi[i];
            }
        }

        Console.WriteLine("Pozitif sayıların toplamı: " + toplam);
    }

    static void NesneYönelimÖrnekArraylerÖrnekleri3() {
        // 10 elemanlı bir dizi içerine rasgele  (1-100) aralığında sayılar atılacaktır.
        // bu dizideki sayılarda en büyüğü ve dizi indis numarasını bulup yazdıran 

        Random rastgele = new Random();
        int[] dizi = new int[10];
        int enBuyuk = 0;
        int enBuyukIndis = 0;

        for (int i = 0; i < 10; i++)
        {
            dizi[i] = rastgele.Next(1, 101);
            Console.WriteLine("Dizi[" + i + "]: " + dizi[i]);

            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
                enBuyukIndis = i;
            }
        }

        Console.WriteLine("En büyük sayı: " + enBuyuk + ", İndis numarası: " + enBuyukIndis);
    }

    static void NesneYönelimÖrnekArraylerÖrnekleri4() {
        // 10 elemanlı bir dizi içerisinde rasgele (1-100 aralığında) sayılar atılacaktır. 
        //bu dizinin ortalamasının en büyük ve en küçük elemanını bulan ve yazdıran 

        Random rastgele = new Random();
        int[] dizi = new int[10];
        double toplam = 0;
        int enBuyuk = 0;
        int enKucuk = 101;

        for (int i = 0; i < 10; i++)
        {
            dizi[i] = rastgele.Next(1, 101);
            Console.WriteLine("Dizi[" + i + "]: " + dizi[i]);
            toplam += dizi[i];

            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }

            if (dizi[i] < enKucuk)
            {
                enKucuk = dizi[i];
            }
        }

        double ortalama = toplam / 10;

        Console.WriteLine("Ortalama: " + ortalama);
        Console.WriteLine("En büyük sayı: " + enBuyuk);
        Console.WriteLine("En küçük sayı: " + enKucuk);

    }

    static void NesneYönelimÖrnekArraylerÖrnekleri5() {
        
        // 10 elemanlı bir dizi içerine klavyeden sayılar girilecektir 
        // bu dizideki çift numaraları kutucuklardaki (indis numarasını çift sayı olan) 
        // sayıların toplamını bulan ve yazdıran 

        int[] dizi = new int[10];
        int toplam = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Sayı girin: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0) // İndis numarası çift ise
            {
                toplam += dizi[i];
            }
        }

        Console.WriteLine("Çift indisli elemanların toplamı: " + toplam);
    }


    static void DecimalBinaryTranslate() {
      
        // Klavyeden girilen Decimal bir sayıyı Binary e çeviren bir programı dizi kullanarak gerçekleştiriniz.

        Console.Write("Ondalık sayı girin: ");
        decimal sayi = decimal.Parse(Console.ReadLine());

        int tamKisim = (int)sayi;
        decimal ondalikKisim = sayi - tamKisim;

        string tamKisimBinary = DecimalToBinary(tamKisim);
        string ondalikKisimBinary = DecimalPartToBinary(ondalikKisim);

        Console.WriteLine($"Tam kısım (Binary): {tamKisimBinary}");
        Console.WriteLine($"Ondalık kısım (Binary): {ondalikKisimBinary}");
    }


    static string DecimalToBinary(int sayi)
    {
        string binary = Convert.ToString(sayi, 2);
        return binary;
    }

    static string DecimalPartToBinary(decimal sayi)
    {
        string binary = "";
        int n = 8; // Ondalık kısım için 8 basamaklı olarak alınabilir, isteğe bağlı olarak değiştirilebilir

        for (int i = 0; i < n; i++)
        {
            sayi *= 2;
            binary += ((int)sayi).ToString();
            if (sayi >= 1)
                sayi -= 1;
        }
        return binary;
    }


    static void NesneYönelimÖrnekArraylerÖrnekleri6() {

        // Satır ve Sütun sayısı klavyeden girilen 2 boyutlu bir dizi (matris) içerisine rastgele harfler
        // atılacaktır. Klavyeden girilen bir kelimeyi bu matris içinde soldan-sağa ve yukarıdan aşağıya
        // aratarak bulunduğu konumları yazdıran programı gerçekleştiriniz.

        Console.Write("Satır Sayısı Giriniz: ");
        int satir = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sütun Sayısı Giriniz: ");
        int sutun = Convert.ToInt32(Console.ReadLine());
        
        Random rastgele = new Random();
        char[,] matris = new char[satir,sutun];

        // Her bir elemanı rastgele harfle doldurun
        for (int i = 0; i < satir; i++)
        {
            for (int a = 0; a < sutun; a++)
            {
                matris[i,a] = (char)('a' + rastgele.Next(0, 26)); // Rastgele küçük harf üret
            }
        }


        for(int i = 0; i < satir; i++)
        {
            for(int a = 0; a < sutun; a++)
            {
                Console.Write(matris[i,a] + " ");
            }
            Console.WriteLine();
        }


        Console.Write("Kelime Arama: ");
        string kelime = Console.ReadLine();
        HarfBulucu(matris, satir,sutun,kelime);

    }

    static void HarfBulucu(char[,] matris, int satir, int sutun, string kelime) {
    int kelimeUzunlugu = kelime.Length;
    for(int i = 0; i < satir; i++) {
        for(int a = 0; a < sutun; a++) {
            if(matris[i,a] == kelime[0]) {
                int kelimeIndex = 1;
                int satirIndex = i;
                int sutunIndex = a + 1;
                while(kelimeIndex < kelimeUzunlugu && sutunIndex < sutun && matris[satirIndex,sutunIndex] == kelime[kelimeIndex]) {
                    kelimeIndex++;
                    sutunIndex++;
                }
                if(kelimeIndex == kelimeUzunlugu) {
                    Console.WriteLine("Kelime Bulundu");
                    return;
                }
            }
        }
    }
    Console.WriteLine("Kelime Bulunamadı");
}


    static void KuraSayacV1() {
        string[] sehir;
        string[] kisi;

        Console.WriteLine("atama sayısı:");
        int atama = Convert.ToInt32(Console.ReadLine());

        sehir = new string[atama];
        kisi = new string[atama];

        Random random = new Random();

        for (int i = 0; i < atama; i++)
        {
            Console.WriteLine("Şehir Giriniz:");
            string şehir = Console.ReadLine(); // Değişken adını düzelt
            sehir[i] = şehir;
        }

        for (int i = 0; i < atama; i++)
        {
            Console.WriteLine("Kişi Giriniz:");
            string kisiler = Console.ReadLine(); // Değişken adını düzelt
            kisi[i] = kisiler;
        }

        int n = kisi.Length;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = kisi[k];
            kisi[k] = kisi[n];
            kisi[n] = value;
        }

        for (int i = 0; i < atama; i++)
        {
            Console.WriteLine("Kişi " + kisi[i] + " Şehir " + sehir[i]);
        }

        Console.ReadKey();

    }

    static void SayisalLoto() {
         Random random = new Random();
        int[] sayilar = new int[6];

        for (int i = 0; i < 6; i++)
        {
            int yeniSayi;
            do
            {
                yeniSayi = random.Next(1, 50);
            } while (Array.IndexOf(sayilar, yeniSayi) != -1);

            sayilar[i] = yeniSayi;
        }

        Array.Sort(sayilar);

        Console.WriteLine("Sayısal Loto 6/49 Sonuçları:");
        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
    }


    static void NesneYönelimÖrnekArraylerÖrnekleri7() {
        Dictionary<string, int> ürünler = new Dictionary<string, int>();
        ürünler["Döner"]    = 0;       
        ürünler["Kumpir"]   = 0;
        ürünler["Pide"]     = 0;
        ürünler["Salata"]   = 0;
        ürünler["Meşrubat"] = 0;

        while(true){
            Console.Write(
@"Ürün                Fiyat
===========================
1) Döner              20.0 TL
2) Kumpir             40.0 TL
3) Pide               55.0 TL
4) Salata             30.0 TL       
5) Meşrubat           15.0 TL

Yeni Sipariş İçin (y) adisyon için (q): ");

            string adisyon = Console.ReadLine();

            if(adisyon[0] == 'y') {
                Console.Write("Ürün Adı: ");
                string ürünAdı = Console.ReadLine();

                // Kullanıcıdan adet alın
                Console.Write("Adet: ");
                int adet = Convert.ToInt32(Console.ReadLine());

                // Dictionary'de ilgili ürünün adetini güncelleyin
                if (ürünler.ContainsKey(ürünAdı)){
                    ürünler[ürünAdı] += adet;
                    Console.WriteLine($"Yeni adet: {ürünler[ürünAdı]}");
                    Console.Write("Siparişiniz Alınmıştır..");
                }
                else{
                    Console.WriteLine("Ürün bulunamadı.");
                }
                Console.ReadKey();
                continue;
            }else if(adisyon[0] == 'q') {
                int toplam = 0;
                Console.WriteLine("Adisyon Tamamlandı..");
                foreach (var ürün in ürünler)
                {
                    // varsayılan toplam fiyat
                    int toplamFiyat = 0;

                    if(ürün.Value != 0) {
                        if(ürün.Key == "Döner") {
                            int toplamDönerFiyat = (ürün.Value * 20);
                            toplamFiyat += toplamDönerFiyat;
                        }
                        if(ürün.Key == "Kumpir") {
                            int toplamKumpirFiyat = (ürün.Value * 40);
                            toplamFiyat += toplamKumpirFiyat;
                        }
                        if(ürün.Key == "Pide") {
                            int toplamPideFiyat = (ürün.Value * 55);
                            toplamFiyat += toplamPideFiyat;
                        }
                        if(ürün.Key == "Salata") {
                            int toplamSalataFiyat = (ürün.Value * 30);
                            toplamFiyat += toplamSalataFiyat;
                        }
                        if(ürün.Key == "Meşrubat") {
                            int toplamMeşrubatFiyat = (ürün.Value * 15);
                            toplamFiyat += toplamMeşrubatFiyat;
                        }
                        toplam += toplamFiyat;
                        Console.WriteLine($"{ürün.Key}: {ürün.Value} adet");
                    }
                }
                Console.WriteLine("Toplam Ücret: " + toplam);
                Console.ReadKey();
                break;
            }else {
                clear();
                continue;
            }

        }
    }


    static void NesneYönelimÖrnekleri() {
        int sayi = 3250;
        umyo.Yaz(sayi);
    }

    // Faktoriyel hesaplayan Method
    static long FaktoriyelHesapla(int sayi)
    {
        if (sayi == 0)
            return 1;
        
        long sonuc = 1;
        for (int i = 1; i <= sayi; i++)
        {
            sonuc *= i;
        }
        return sonuc;
    }


}


public class umyo
{
    public static void Yaz(int sayi)
    {
        string sayiStr = sayi.ToString();
        foreach (char c in sayiStr)
        {
            Console.WriteLine(c);
        }
    }

}
