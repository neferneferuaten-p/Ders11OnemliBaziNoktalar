using System;

namespace Ders11OnemliBaziNoktalar
{
    class Program
    {
        static void Main(string[] args)
        {
            // string; referans türlü olmasına karşın programlama dillerinde bir keyword barındıran tek değerdir.

            string a = "Oğuzhan";
            // Burada Oğuzhan değeri Heap'de tutulacaktır.

            #region Null - Empty Durumları, Farkları
            #region Null
            // bir değişken null/nullable/ referans eğerki null alıyorsa bu durum bellekte yer işgal emediği anlamına gelir
            // Sadece referans türler null alabilir
            // değer türlü değişkenlerin null alabilmesi için nullable yapmalıyız (int? a = Null;) şeklinde
            // Run time hatasına sebep olur

            #endregion
            #region Empty
            // bir değişken eğer ki empty ise bu değişkenin değeri yok demektir fakat bellekte alan ayrılmıştır.
            // Tüm değerlere atanabilir
            // Default durumlar Empty olarak nitelendirilir int[] x = new int[5]; gibi
            string c = "";
            string d = string.Empty; // şeklinde tanımlanabilir
            #endregion

            #region IsNullOrEmpty
            string x = ""; // Empty

            if (x != string.Empty && !(x is null))
            {
                // Operasyon
            }
            // yukadaki ifade yerine bunu yazabiliriz

            if (string.IsNullOrEmpty(x))
            {
                // Operasyon
            }


            #endregion

            #region IsNullOrWhiteSpace
            // Elimizdeki string ifadenin null, empty yahut boşluk karakterlerinden ibaret olma durumuda geriye boolean "true" değer döndüren bir fonksiyondur.
            string zz = "            ";
            string aa = null;
            if (string.IsNullOrWhiteSpace(zz) && string.IsNullOrWhiteSpace(aa))
            {
                Console.WriteLine("true");
            }
            #endregion
            #endregion

            #region string not
            // Yazılım açısından string ifade yoktur char'ların bir araya gelmiş hali vardır, string ifadeler char dizisini ifade etmektedirler.
            // string ifadelerin her bir karakteri otomatik indexlenmektedir, bu yüzden indexer operatörünü kullanabilmekteyiz

            string metin = "sebepsiz boş yere ayrılacaksaaaan.....";

            Console.WriteLine(metin[4]);
            Console.WriteLine(metin.Length);

            // Array'e atayamayız ama.

            for (int i = 0; i < metin.Length; i++)
            {
                Console.Write(metin[i]);
            }
            #endregion

            #region string formatlandırma

            string isim = "Oğuzhan"; string soyisim = "Gül"; string tcNo = "432141241324321";
            int yas = 24;
            bool medeniHal = false;

            Console.WriteLine("Tc No" + tcNo + "İsim :" + isim + "Soyisim :" + soyisim + "Yaş :" + yas + "Medeni hal :" + (medeniHal ? "Evli" : "Bekar"));

            string sonuc = string.Format("Tc No : {0} olan {1} {2} şahsın bilgileri | Yaş : {3} | Medeni hal : {4}", tcNo, isim, soyisim, yas, medeniHal ? "Evli" : "Bekar");
            Console.WriteLine(sonuc);

            #region string interpolation
            Console.WriteLine("string interpolation");
            // string ifadeler içersinde süslü parantez ile araya girere programatik bir değişkeni birakmamızı sağlayan bir operatördür
            // string ifadenin başına  $ işareti koyarsak interpolation ifadesi oluşur
            Console.WriteLine($"Tc No { tcNo } İsim : { isim } Soyisim : { soyisim } Yaş : { yas } Medeni hal : { (medeniHal ? "Evli" : "Bekar")} {{2 adet süslü parantez birbirini ezer}}");

            // string.Format yine arka planda kullanılır

            #endregion

            #region Kaçış karakterleri


            Console.WriteLine("1.kaçış karakteri = \\ ");

            // kendisinden sonra gelen karakterin özel bir karakter olmadını metinsel bir karakter olduğunu ifade eder.

            Console.WriteLine("2.kaçış karakteri = \\a ");

            // Bip sesi çıkarır.

            Console.WriteLine("3.kaçış karakteri = \\b ");

            // Önceki karakteri siler.

            Console.WriteLine("4.kaçış karakteri = \\t ");

            // Tab oluşturma karakteridir

            Console.WriteLine("5.kaçış karakteri = \\r ");

            // Satır başı 

            Console.WriteLine("6.kaçış karakteri = \\n ");

            // Bir alt satıra iner

            Console.WriteLine("7.kaçış karakteri = \\v ");

            // Dikey Tab

            Console.WriteLine("8.kaçış karakteri = \\f ");

            // Sayfa ilerleme

            Console.WriteLine("9.kaçış karakteri = \\o ");

            // Null sonlandırma karakteri.

            string asdf = @"gsdfgfsdg""sadfsfa"" "; // Verbatim strings operatörü bu şekilde escape karakterleri ezmek için kullanılabilir

            string adsfas = @"sfsadfd
                            fasdfdasfas"; // Bu şekilde alt satıra inmemize rağmen hata vermemesini de sağlayabilir, normalde bu şekilde yazmaya çalışırsak compiler hata verir


            #endregion


            #endregion
        }
    }
}
