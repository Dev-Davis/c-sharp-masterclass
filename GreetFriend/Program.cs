using System;

namespace GreetFriend
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string friend1 = "Korey";
            string friend2 = "Kortney";
            string friend3 = "Shay";
            Console.WriteLine(GreetFriend(friend1));
            Console.WriteLine(GreetFriend(friend2));
            Console.WriteLine(GreetFriend(friend3));
        }

        public static string GreetFriend(string friend)
        {
            return ($"Hi {friend}, my friend");
        }
    }
}
