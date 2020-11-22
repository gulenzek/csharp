using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long number = RequestNumberFromConsole("Enter a number: ");
                System.Console.WriteLine(MagicString(number));
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public static string MagicString(long number){
            if(number <= 0)
                throw new ArgumentException("Number must be positive");

            string result = "";

            for(long i = 1L; i<number + 1; i++){
                for(long j = 0L; j<i; j++)
                    result += i;
            }

            return result;
        }

        public static long RequestNumberFromConsole(string message){
            System.Console.Write(message);
            string input = Console.ReadLine();
            return long.Parse(input);
        }
    }
}
