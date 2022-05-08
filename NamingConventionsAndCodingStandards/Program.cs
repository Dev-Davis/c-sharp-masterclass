using System;

namespace NamingConventionsAndCodingStandards
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 1234567;
            long bigNumber = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;

            // cast double to int - explicit conversion
            myInt = (int)myDouble;
            // Console.WriteLine(myInt);
            // Console.Read();

            //type conversion
            string myString = myDouble.ToString();
            num.ToString();
            string myFloatString = myFloat.ToString();
            bool isSunShinning = false;

            string firstTwo = "19";
            string secondTwo = "86";
            int num1 = Int16.Parse(firstTwo);
            int num2 = Int32.Parse(secondTwo);  
            int sum = num1 + num2;

            Console.WriteLine(sum);
            Console.Read();

            Console.WriteLine(isSunShinning);
            // Console.Read();
        }
    }
}
