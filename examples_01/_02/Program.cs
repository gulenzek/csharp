using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> evenNumbers = new List<long>();
            for (int i = 0; i < 20; i++)
            {
                try{
                    long number = RequestNumberFromConsole($"Enter Number {i + 1}: ");
                    if(isEven(number)){
                        evenNumbers.Add(number);
                    }
                }catch(Exception){
                    System.Console.WriteLine("You gave wrong input.");
                    i--;
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Odd Elements");
            PrintListElements(evenNumbers);
            System.Console.WriteLine();

            double average =  Average(evenNumbers);
            System.Console.WriteLine("Average = "+ average);

        }

        public static void PrintListElements(List<long> numbers){
            foreach(long number in numbers){
                System.Console.WriteLine(number);
            }
        }

        public static long RequestNumberFromConsole(string message)
        {
            System.Console.Write(message);
            return long.Parse(Console.ReadLine());
        }

        public static double Average(List<long> numbers){
            return numbers.Average();
        }

        public static bool isEven(long number){
            return number % 2 == 0;
        }
    }
}
