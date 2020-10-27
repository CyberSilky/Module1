using System;
using static System.Console;


namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int userValue1, userValue2;

            int total = Addition(4, 5, 56, 23, 79, 12);
            WriteLine($"The total is: {total}");
        }

        static int Addition(params int[] numbers)
        {
            int total = 0;
            foreach(int number in numbers)
            {
                total = total + number;
            }

            return total;
        }
    }
}
