using System;

namespace ConsoleApp2_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than" + " " + age);

        }
    }
}
