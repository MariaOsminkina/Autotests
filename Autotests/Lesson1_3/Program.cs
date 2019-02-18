using System;

namespace Lesson1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\nEnter first string:");
            string firstString = Console.ReadLine().ToUpper();

            Console.WriteLine("\r\nEnter second string:");
            string secondString = Console.ReadLine().ToUpper();

            Console.WriteLine("\r\nEnter third string:");
            string thirdString = Console.ReadLine().ToUpper();

            bool res = firstString.StartsWith(secondString);
            Console.WriteLine("\r\nString {0} starts from {1}: {2}", firstString, secondString, res);

            res = firstString.EndsWith(thirdString);
            Console.WriteLine("\r\nString {0} ends with {1}: {2}", firstString, thirdString, res);

            Console.WriteLine("\r\nThe end =)");
            Console.ReadLine();
        }
    }
}
