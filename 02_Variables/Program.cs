using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice= 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " TL"
            //    + " - Gramaj: " + appleGram + " KG" + " - Toplam Tutar: " + appleTotalPrice
            //    + " TL");

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " TL"
            //    + " - Gramaj: " + orangeGram + " KG" + " - Toplam Tutar: " + orangeTotalPrice
            //    + " TL");

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " TL"
            //    + " - Gramaj: " + strawberryGram + " KG" + " - Toplam Tutar: " + strawberryTotalPrice
            //    + " TL");

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " TL"
            //    + " - Gramaj: " + potatoGram + " KG" + " - Toplam Tutar: " + potatoTotalPrice
            //    + " TL");

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " TL"
            //    + " - Gramaj: " + tomatoGram + " KG" + " - Toplam Tutar: " + tomatoTotalPrice
            //    + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice +
            //    potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alisveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region CharDegiskenler

            //ABCDEFGH
            //DEF...
            // " değil
            // ' ile

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirisleri-StringDegiskenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC Kimlik Numarası: " + passengerIdentityNumber + " " 
            //    + "Yolcu Adı ve Soyadı: "+  passengerName + " " + passengerSurname + " " + "Yolcu Adresi: "
            //    + passengerDistrict + "/" + passengerCity + " " + "Yolcu Yaşı: " + passengerAge);

            #endregion

            #region KlavyedenTamSayiGirisleriVeDonusumler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine("Toplan Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            #region KlavyedenOndalikliSayiIslemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen Birinci Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen Üçüncü Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.WriteLine();

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Ortalamanız: " +  result);

            #endregion

            #region KlavyedenKarakterGirisleri

            //char gender;

            //Console.Write("Lütfen Cinsiyetinizin İlk Harfini Yazınız: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyet: " +  gender);

            #endregion

            Console.Read();
        }
    }
}