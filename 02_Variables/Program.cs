using System;
using System.Text;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("**** Fiyat Listesi ****");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Elma Birim Fiyatı:" + applePrice + "₺");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Portakal Birim Fiyatı:" + orangePrice + "₺");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Patates Birim Fiyatı:" + potatoPrice + "₺");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Domates Birim Fiyatı:" + tomatoPrice + "₺");
            Console.WriteLine();
            Console.WriteLine();

            Double appleGram, orangeGram, strawberyyGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberyyGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberyyGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün:Elma" + "-Birim Fiyatı:" + applePrice + "-Gramaj:" + appleGram + "-Toplam Tutarı:" + appleTotalPrice);
            Console.WriteLine("Alınan Ürün:Elma" + "-Birim Fiyatı:" + orangePrice + "-Gramaj:" + orangeGram + "-Toplam Tutarı:" + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün:Elma" + "-Birim Fiyatı:" + strawberryPrice + "-Gramaj:" + strawberyyGram + "-Toplam Tutarı:" + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün:Elma" + "-Birim Fiyatı:" + potatoPrice + "-Gramaj:" + potatoGram + "-Toplam Tutarı:" + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün:Elma" + "-Birim Fiyatı:" + tomatoPrice + "-Gramaj:" + tomatoGram + "-Toplam Tutarı:" + tomatoTotalPrice);


            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "₺");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yollar Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCtiy,passengerAge, 
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Biilgisi:");
            //passengerCtiy = Console.ReadLine();
            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:"+ passengerIdentityNumber +"-Yolcu Ad Soyad:"
            //    +passengerName+""+passengerSurname +""+ passengerDistrict+ "/"+passengerCtiy+""+passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;


            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lüten aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lüten aldığınız sanadalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lüten aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar:" + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri 

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunuzu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 1.Sınav notunuzu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 1.Sınav notunuzu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:" + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Değerinizi Giriniz");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);

            #endregion

            #region




            #endregion
            Console.Read();


        }
    }
}
