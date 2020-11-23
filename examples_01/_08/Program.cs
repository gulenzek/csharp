using System;
using System.Collections.Generic;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, long> moneys = GiveMoneys(5605);

                foreach (int key in moneys.Keys)
                {
                    System.Console.WriteLine($"{moneys[key]} {key}");
                }


            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public static Dictionary<int, long> GiveMoneys(long number)
        {
            if (number % 5 != 0)
                throw new ArgumentException("Number must be a multiple of five");

            Dictionary<int, long> moneys = new Dictionary<int, long>();


            Queue<int> divides = new Queue<int>();
            divides.Enqueue(200);
            divides.Enqueue(100);
            divides.Enqueue(50);
            divides.Enqueue(20);
            divides.Enqueue(10);
            divides.Enqueue(5);

            while (divides.Count > 0)
            {
                int divide = divides.Dequeue();
                long howMany = number / divide;

                if (howMany != 0)
                    moneys.Add(divide, howMany);

                number %= divide;
            }


            return moneys;



        }




    }


}
