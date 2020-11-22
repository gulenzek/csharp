using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                long number1 = RequestNumberFromConsole("Enter Number 1: ");
                long number2 = RequestNumberFromConsole("Enter Number 2: ");

                long gcd = GCD(number1, number2);

                System.Console.WriteLine(gcd);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public static long GCD(long number1, long number2)
        {
            long divide = 2;

            long result = 1;

            if (number1 == 0 || number2 == 0)
                throw new ArgumentException("The GCD of zero does not exist");

            while (number1 != 1 || number2 != 1)
            {
                if (number1 % divide == 0 && number2 % divide == 0)
                {
                    number1 /= divide;
                    number2 /= divide;
                    result *= divide;

                    divide--;
                }
                else if (number1 % divide == 0)
                {
                    number1 /= divide;
                    divide--;
                }
                else if (number2 % divide == 0)
                {
                    number2 /= divide;
                    divide--;
                }

                divide++;
            }

            return result;
        }

        public static long RequestNumberFromConsole(string message)
        {
            System.Console.Write(message);
            return long.Parse(Console.ReadLine());
        }
    }
}
