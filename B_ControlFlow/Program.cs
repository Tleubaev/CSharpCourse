using System;
using System.Numerics;

namespace B_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Auth()
        {
            string login = "Oralbek";
            string password = "123";
            int authCounter = 0;

            while (authCounter < 3)
            {
                Console.WriteLine("Enter your login");
                string inputLogin = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string inputPassword = Console.ReadLine();
                authCounter++;

                if (login == inputLogin && password == inputPassword)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }

            if (authCounter == 3)
            {
                Console.WriteLine("The number of available tries have been exeeded");
            }

            // 2й вариант
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter your login");
            //    string inputLogin = Console.ReadLine();
            //    Console.WriteLine("Enter your password");
            //    string inputPassword = Console.ReadLine();
            //    authCounter++;

            //    if (login == inputLogin && password == inputPassword)
            //    {
            //        Console.WriteLine("Enter the System");
            //        break;
            //    }
            //    else if (authCounter == 3)
            //    {
            //        Console.WriteLine("The number of available tries have been exeeded");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try again");
            //    }
            //}
        }
        static void Factorial()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorialNumber = 1;

            for (int i = 1; i <= number; i++)
            {
                factorialNumber *= i;
            }
            Console.WriteLine(factorialNumber);
        }
        static void CalculateMiddleNumber()
        {
            int[] numbers = new int[10];
            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;
                inputCount++;

                if (number == 0)
                    break;
            }

            int sum = 0;
            int count = 0;
            foreach (int n in numbers)
            {
                if (n != 0)
                    Console.Write(n + " ");
                if (n % 3 == 0 && n != 0)
                {
                    sum += n;
                    count++;
                }
            }
            Console.WriteLine();
            if (count == 0)
            {
                Console.WriteLine("Нет кратных 3м");
            }
            else
            {
                Console.WriteLine(sum / count);
            }
        }
        static void FibonachiNumbers()
        {
            int counter = int.Parse(Console.ReadLine());
            int[] fibonachiList = new int[counter];
            int a = 1;
            int b = 1;

            for (int i = 0; i < counter; i++)
            {
                fibonachiList[i] = a;
                int c = b;
                b = a + b;
                a = c;
            }
            Console.WriteLine(fibonachiList);

            foreach (int num in fibonachiList)
            {
                Console.Write(num + " ");
            }
        }
        static void SwitchCase()
        {
            int month = int.Parse(Console.ReadLine());
            string season = String.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("ERROR!");
                    season = "Нет такого месяца";
                    break;
            }
            Console.WriteLine(season);


            Console.ReadLine();


            int number = int.Parse(Console.ReadLine());
            string name = String.Empty;
            switch (number)
            {
                case 5:
                    name = "Деревянная";
                    break;
                case 10:
                    name = "Оловянная";
                    break;
                case 15:
                    name = "Хрустальная";
                    break;
                case 20:
                    name = "Фарфоровая";
                    break;
                case 25:
                    name = "Серебряная";
                    break;
                case 30:
                    name = "Жемчужная";
                    break;
                case 40:
                    name = "Рубиновая";
                    break;
                case 50:
                    name = "Золотая";
                    break;
                default:
                    name = "Не круглая дата";
                    break;
            }
            Console.WriteLine(name);
        }
    }
}
