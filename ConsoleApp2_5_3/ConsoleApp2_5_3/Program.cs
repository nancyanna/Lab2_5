using System;

namespace ConsoleApp2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Enter a value for the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the thrid number:");
            number3 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2 * number3;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);
        }
    }
}
