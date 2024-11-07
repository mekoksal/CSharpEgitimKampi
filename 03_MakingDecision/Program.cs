using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Please enter the password: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Password Correct");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect Password");
            //}

            //string capital, country;
            //Console.Write("Enter the capital: ");
            //capital = Console.ReadLine();

            //Console.Write("Enter the country: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "turkey")
            //{
            //    Console.Write("Data verified");
            //}
            //else
            //{
            //    Console.Write("Incorrect data");
            //}

            //int number;
            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Correct number");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect number");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Error!";

            //Console.Write("Exam 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Exam 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Exam 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average of the exams: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Result: Poor";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Result: Average";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Result: Good";
            //}
            //if (average > 84)
            //{
            //    result = "Result: Excellent";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Please enter a city: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="ankara" | city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("City available");
            //}
            //else
            //{
            //    Console.WriteLine("City not available");
            //}

            //Console.Write("Please enter your username: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("This username is not accepted");
            //}
            //else
            //{
            //    Console.Write("Welcome");
            //}

            #endregion

            #region Mod Operations

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Please enter the first number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("The remainder of the division of the first number by the second number: " + result);

            //Console.Write("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("The number is even");
            //}
            //else
            //{
            //    Console.Write("The number is odd");
            //}

            #endregion

            #region Char Variables with Conditional Statements

            //char team;
            //Console.Write("Please enter the team symbol: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahce");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Besiktas");
            // }

            #endregion

            #region Example Project Application

            //Console.WriteLine("****** C# Training Camp Restaurant ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Main Dishes");
            //Console.WriteLine("2-Soups");
            //Console.WriteLine("3-Pizzas");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuChoice;

            //Console.Write("Choose a menu to see details: ");
            //menuChoice = Console.ReadLine();

            //if (menuChoice == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Main Dishes------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Curry Chicken");
            //    Console.WriteLine("2-Fried Platter");
            //    Console.WriteLine("3-Fasulye Pilaf");
            //    Console.WriteLine("4-Oven Salmon");
            //    Console.WriteLine("5-Aubergine Moussaka");
            //    Console.WriteLine("------------Main Dishes------------");
            //    Console.WriteLine();
            //}

            //if (menuChoice == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Soups------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Lentil Soup");
            //    Console.WriteLine("2-Ezogelin Soup");
            //    Console.WriteLine("------------Soups------------");
            //    Console.WriteLine();
            //}

            //if (menuChoice == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzas------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mediterranean Pizza");
            //    Console.WriteLine("2-Margherita");
            //    Console.WriteLine("3-Chicken Pizza");
            //    Console.WriteLine("------------Pizzas------------");
            //    Console.WriteLine();
            //}

            //if (menuChoice == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Drinks------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Yogurt Drink");
            //    Console.WriteLine("3-Water");
            //    Console.WriteLine("------------Drinks------------");
            //    Console.WriteLine();
            //}

            //if (menuChoice == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Desserts------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilece");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Rice Pudding");
            //    Console.WriteLine("------------Desserts------------");
            //    Console.WriteLine();
            //}

            #endregion
            
            #region Switch Case

            //Console.Write("Please enter a month number: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("January"); break;
            //    case 2: Console.Write("February"); break;
            //    case 3: Console.Write("March"); break;
            //    case 4: Console.Write("April"); break;
            //    case 5: Console.Write("May"); break;
            //    case 6: Console.Write("June"); break;
            //    case 7: Console.Write("July"); break;
            //    case 8: Console.Write("August"); break;
            //    case 9: Console.Write("September"); break;
            //    case 10: Console.Write("October"); break;
            //    case 11: Console.Write("November"); break;
            //    case 12: Console.Write("December"); break;
            //    default: Console.Write("Invalid input"); break;
            //}

            #endregion

            #region Switch Case Calculator

            //int number1, number2, result;
            //char operatorSymbol;

            //Console.Write("Enter first number: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the operation (+, -, *, /): ");
            //operatorSymbol = char.Parse(Console.ReadLine());

            //switch (operatorSymbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sum: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Difference: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Product: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Quotient: " + result);
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
