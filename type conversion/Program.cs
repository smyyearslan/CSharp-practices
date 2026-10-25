using System;

namespace consoleApp
{
    class Conversion
    {
        static void Main(string[] args)
        {
            Console.Write("1. number: ");
            var num1 = Console.ReadLine();

            Console.Write("2. number: ");
            var num2 = Console.ReadLine();

            var sum = num1 + num2;

            Console.WriteLine(sum); //writes the numbers side by side

            Console.Write("1. number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var sum2 = number1 + number2;

            Console.WriteLine(sum2); //writes the sum of the numbers

        }
    }
}