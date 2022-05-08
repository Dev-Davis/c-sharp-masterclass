using System;

namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a few variables
            // int age = 35;
            // string name = "Dott";
            // string occupation = "Software Developer";

            // 1. string concatenation 
            // Console.WriteLine("String Concatentation");
            // Console.WriteLine("Hello, my name is " + name + " , and I am " + age + " years old");

            // 2. string formatting
            // string formatting uses the index
            // Console.WriteLine("String Formatting");
            // Console.WriteLine("Hello, I go by {0}, a {2} , and I am {1} years old for now", name, age, occupation);

            // 3. string interpolation
            // string interpolation uses a $ at the beginning which will allow us to write our variables ike {this}
            // Console.WriteLine("String Interpolation");
            // Console.WriteLine($"Hello, I'm {name}. I'm a {occupation}, and I'm {age} years old.");

            // 4. verbatim stringsverbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escapes characters like \n (\n creates a new ine without the @ sign)
            // Console.WriteLine("Verbatim strings");
            // Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc quis sem nec mauris dictum tristique non a odio. Vivamus semper feugiat 
            // tortor nec ultricies. Aliquam gravida rutrum facilisis. Sed porta ex eros, id vulputate nibh porta sed. Phasellus enim lorem, scelerisque vel felis vitae, 
            // feugiat bibendum lectus. Nunc venenatis porttitor interdum. Integer ac euismod metus. Sed quis imperdiet orci, at porttitor sem. Etiam consequat purus in tortor 
            // consequat ultrices. Etiam aliquam dignissim malesuada. Maecenas venenatis enim non dignissim tempus.");

            string name;
            Console.WriteLine("Please enter your name and press enter...");
            name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name);
            string substring = name.Substring(0, 2);
            Console.WriteLine(substring);

        }
    }
}
