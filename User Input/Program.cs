using System;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add two numbers together to see your answer...");
            Console.WriteLine("Type your first number...");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type your second number...");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"your answer is {num1 + num2}");
        }
    }
}
