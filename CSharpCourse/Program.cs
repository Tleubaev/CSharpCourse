using System;
using System.Numerics;

namespace CSharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void BodyMassIndex()
        {
            Console.WriteLine("Write your first name:");
            string name = Console.ReadLine();

            Console.WriteLine("Write your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Write your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Write your height:");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = Math.Round(weight / (height * height));
            Console.WriteLine("Your Profile: \n" +
                $"Full name: {name} {lastName}\n" +
                $"Age {age}\n" +
                $"Weight {weight}\n" +
                $"Height {height}\n" +
                $"Body Mass Index {bodyMassIndex} \n");
        }
        static void GeroneFunctionHomeWork()
        {
            Console.WriteLine("Please, write a, b, c - line length...");

            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c = ");
            int c = int.Parse(Console.ReadLine());

            int p = (a + b + c) / 2;
            double S = Math.Round(Math.Sqrt(Math.Abs(p * (p - a) * (p - b) * (p - c))));

            Console.WriteLine($"Площадь треугольника по формуле Герона равна {S}");
        }
        static void HomeWork()
        {
            Console.WriteLine("Please, write your name ...");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("Write x number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Write y number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"X = {x}, Y = {y}");
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
            Console.WriteLine($"X = {x}, Y = {y}");


            Console.WriteLine("Write a number, please...");
            int length = Console.ReadLine().Length;
            Console.WriteLine(length);
        }
        static void ConsoleComands()
        {
            Console.WriteLine("Hi, please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);
            Console.WriteLine($"Your age is {age}");

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("New Style ");
            Console.Write("New Style \nNew");
        }
        static void ComparingString()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
        }
        static void StringFormating()
        {
            string str1 = "My name is \nOralbek";
            str1 = $"My name is {Environment.NewLine}Oralbek";  // Универсальный перенос, работает на разных устройствах
            str1 = "I'm \t30"; // tabulation

            string str2 = "I'm Oralbek, and n am a \"good\" programmer";

            string str3 = "C:\\program-files\\windows";
            string str4 = @"C:\tabs\t";

            double answer = 42.05;
            string str5 = string.Format("{0:d}", answer);
            string str6 = string.Format("{0:d4}", answer);

            decimal d = 12.05667m;
            int i = 5;

            Console.WriteLine("Значение переменной d = {0:C}, а n = {1}", d, i);

            DateTime myDate = DateTime.Now;
            Console.WriteLine("Дата в формате d: {0:d}\nВ формате D: {0:D}", myDate);
            Console.WriteLine("Дата в формате f: {0:f}\nВ формате F: {0:F}", myDate);
            Console.WriteLine("Дата в формате g: {0:g}\nВ формате G: {0:G}", myDate);
            Console.WriteLine("Дата в формате m: {0:m}\nВ формате M: {0:M}", myDate);
            Console.WriteLine("Дата в формате r: {0:r}\nВ формате R: {0:R}", myDate);
            Console.WriteLine("Дата в формате o: {0:o}\nВ формате O: {0:O}", myDate);
            Console.WriteLine("Дата в формате s: {0:s}", myDate);
            Console.WriteLine("Дата в формате t: {0:t}\nВ формате T: {0:T}", myDate);
            Console.WriteLine("Дата в формате u: {0:u}\nВ формате U: {0:U}", myDate);
            Console.WriteLine("Дата в формате y: {0:y}\nВ формате Y: {0:Y}", myDate);
        }
    }
}
