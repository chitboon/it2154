using System;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("key in a list of integer numbers separated by space:");
            string numbers = Console.ReadLine();
            int sum = 0;
            string[] numbers_arr = numbers.Split(" ");
            foreach (var number in numbers_arr)
            {
                sum = sum + Int32.Parse(number);
            }
            Console.WriteLine($"The average is {sum / numbers_arr.Length}.");
        }
    }
}
