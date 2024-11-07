using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Loop
            //Loops 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(start; end; step)
            //start:initial value
            //end:limit
            //step:increment/decrement

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Training Camp");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Please enter the number of times to display the message: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Long Live the Republic");
            //}

            #endregion

            #region For Loop with Conditional Statements

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //1-2-4-8-16-...

            //int bacteria = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteria *= 2;
            //    Console.WriteLine(i + ". Hour Result: " + bacteria);
            //}

            #endregion

            #region While Loop

            //While(condition)
            //{
            //    statements
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Loops");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Example Exam Question

            //Write the code to calculate the sum of the digits of a 3-digit number entered from the keyboard.

            //int number;
            //int total = 0;
            //int k = 0;
            //int l = 0;
            //int m = 0;
            //Console.Write("3 basamaklı sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //k = number % 10;
            //Console.WriteLine("Birler basamağı: " + k);

            //l = (number % 100 - k) / 10;
            //Console.WriteLine("Onlar basamağı: " + l);

            //m = number / 100;
            //Console.WriteLine("Yüzler basamağı: " + m);

            //total = k + l + m;

            //Console.WriteLine("Basamaklar toplamı: " + total);

            #endregion

            //Console.Read();


        }
    }
}