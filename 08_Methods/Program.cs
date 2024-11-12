using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //Methodların sonunda () olmalı. (parantez)
            //Geriye değer döndürmeyen methodlar
            //Customer--> listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Hakan Yılmaz");
            //    Console.WriteLine("Baran Bilal");
            //    Console.WriteLine("Görkem Özdemir");
            //    Console.WriteLine("Ekin Bakkalbaşı");

            //}

            //CustomerList(); //Burada methodu çağırmasaydık void olduğu için çıktı vermeyecekti...


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerame) { 

            //    Console.WriteLine(customerame);
            //}

            //WriteMethod("Seyit Maydın");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Erkam","Aydın");
            //CustomerCard("Yasir","Gayretli");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName(); //Çıktı vermez...


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string country, string capital, string flagColor) { 

            //    string cardInfo = "Ülke: " + country + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //Console.WriteLine("Ülke adını giriniz: ");
            //string x = Console.ReadLine();

            //Console.WriteLine("Başkent adını giriniz: ");
            //string y = Console.ReadLine();

            //Console.WriteLine("Bayrak rengini giriniz: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) { 

            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(78, 23));
            //Console.WriteLine(Sum(780, 143));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{

            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {

            //        return student + " isimli öğrenci sınavı geçti. Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali ", 75, 24, 64));
            //Console.WriteLine(ExamResult("Ayşe ", 53, 12, 87));
            //Console.WriteLine(ExamResult("Hakan ", 17, 23, 45));

            #endregion

            Console.Read();

        }
    }
}
