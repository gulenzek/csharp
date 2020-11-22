using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;


            for (int i = 0; i < 20; i++)
            {
                try{
                    double number = RequestNumberFromConsole($"Enter Number {i + 1}: ");
                    if(minValue > number)
                        minValue = number;
                    if(maxValue < number)
                        maxValue = number;
                }catch(Exception e){
                    System.Console.WriteLine("Something went wrong.");
                    System.Console.WriteLine(e.Message);
                    i--;
                }
            }

            System.Console.WriteLine($"Min Value = {minValue}, Max Value = {maxValue}");
        }

        public static double RequestNumberFromConsole(string message)
        {
            System.Console.Write(message);
            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
