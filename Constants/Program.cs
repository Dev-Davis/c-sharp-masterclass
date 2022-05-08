using System;

namespace Constants
{
    // constants are immutable values whch are known at compile time amd do not change for the life of the program
    internal class Program
    {
        // consts are fields which are in the class, but outside of the method
        // constants as field
        const double PI = 3.1415926535;
        // you can declare more that one in a single const
        const int weeks = 52, months = 12;
        const string bday = "07.27.1986";
        const string bday1 = "07.16.1986";
        const string bday2 = "10.01.1986";

        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always going to be: {bday}");
            Console.ReadKey();
        }
    }
}
