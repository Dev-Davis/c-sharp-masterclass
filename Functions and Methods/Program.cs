using System;

namespace Functions_and_Methods
{
    internal class Program
    {
        // method
        // <Access Specifier> <Return Type> <Method Name>(Parameter List) { Method Body }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1,2), Add(3,4)));
            Console.WriteLine(Add(27, 31));
            Console.WriteLine(Multi(9, 9));
            Console.WriteLine(Divide(83, 9));
            WriteSomethingSpecific("Blow Ya Whistle");
        }

        // access modifier (static) return type (void) method name (param1, param2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multi(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
