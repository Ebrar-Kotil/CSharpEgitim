using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları 

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("selam");


            //Console.WriteLine("**** Yemek Katagorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Katagorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;
            //string name;
            //name = "Ebrar";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ebrar";
            //customerSurname = "Kotil";
            //customerPhone = "+90 542 722 86 52";
            //customerEmail = "ebrarkotill@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("*** Rezarvasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri:"+ customerName+""+customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            //customerName = "Betül";
            //customerSurname = "Kotil";
            //customerPhone = "+90 530 225 09 52";
            //customerEmail = "ebrarkotill@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + "" + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------------");



            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrica = 50;
           

            Console.WriteLine("****Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger:+" + hamburgerPrice + "TL");
            Console.WriteLine("Pizza:+" + pizzaPrice + "TL");
            Console.WriteLine("Kola:+" + cokePrice + "TL");
            Console.WriteLine("Kızartma:+" + friesPrice + "TL");
            Console.WriteLine("Limonata:+" + lemonadePrica + "TL");
            Console.WriteLine("Su:+" + waterPrice + "TL");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrica;


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı:+" + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı:+" + totalPizzaPrice + "TL");
            Console.WriteLine("Kola Tutarı:+" + totalCokePrice + "TL");
            Console.WriteLine("Kızartma Tutarı :+" + totalFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı:+" + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı:+" + totalWaterPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + 
                totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "TL");
            #endregion
            Console.Read();

        }
    }
}
