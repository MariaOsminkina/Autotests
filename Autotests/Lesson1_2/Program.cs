using System;

namespace Lesson1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\r\nEnter width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nEnter height:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nEnter length:");
            int length = int.Parse(Console.ReadLine());

            var res = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(length, 2));

            Console.WriteLine("\r\nParallelepiped diagonal length: {0}", res);

            Console.WriteLine("\r\nThe end =)");
            Console.ReadLine();
        }
    }
}
