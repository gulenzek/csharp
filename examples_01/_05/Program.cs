using System;
using System.Collections.Generic;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> negativeNumbers = new List<double>();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    double number = RequestNumberFromConsole($"Enter Number {i + 1}: ");
                    if (IsNegative(number))
                    {
                        negativeNumbers.Add(number);
                    }
                }
                catch (Exception)
                {
                    System.Console.WriteLine("You gave wrong input.");
                    i--;
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Negative Numbers");
            PrintListElements(negativeNumbers);
            System.Console.WriteLine();

            int count = negativeNumbers.Count;
            System.Console.WriteLine("Count = " +count);
        }

        public static double RequestNumberFromConsole(string message)
        {
            System.Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        public static bool IsNegative(double number)
        {
            return number < 0;
        }

        public static void PrintListElements(List<double> numbers)
        {
            foreach (double number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
