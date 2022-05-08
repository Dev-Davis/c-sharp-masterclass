using System;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
        }

        public static int Calculate()
        {
            Console.WriteLine("Add two numbers together to see your answer...");
            Console.WriteLine("Type your first number...");
            string input1 = Console.ReadLine();
            Console.WriteLine("Type your second number...");
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int answer = num1 + num2;
            Console.WriteLine("Your answer is...");
            return answer;
        }
    }
}
