using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number1 = RequestNumberFromConsole("Give Number 1: ");
                string operation = RequestOperationFromConsole("Give Operation(+, -, *, /): ");
                double number2 = RequestNumberFromConsole("Give Number 2: ");


                double result = Apply(number1, number2, operation);

                System.Console.WriteLine($"{number1} {operation} {number2} = {result}");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                System.Console.WriteLine("Something went wrong");
            }

        }

        public static double Apply(double number1, double number2, string operation)
        {
            if (operation == "+")
                return number1 + number2;
            else if (operation == "-")
                return number1 - number2;
            else if (operation == "*")
                return number1 * number2;
            else if (operation == "/")
                return number1 / number2;

            throw new ArgumentException("Wrong Argument");
        }

        public static double RequestNumberFromConsole(string message)
        {
            System.Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        public static string RequestOperationFromConsole(string message)
        {
            System.Console.Write(message);

            string input = Console.ReadLine();

            if (input == "+" || input == "-" || input == "/" || input == "*")
                return input;

            throw new ArgumentException("Argument must be +, -, /, *");
        }
    }
}
