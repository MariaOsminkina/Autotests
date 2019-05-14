using System;

namespace AutotestLesson1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int isInt(string value)
            {
                bool isCorrect = int.TryParse(value, out int res);
                if (!isCorrect) {
                    Console.WriteLine("\r\nIncorrect value. Integer is needed.");
                    Console.ReadLine();
                }
                return res;
            }

            Console.Clear();

            Console.WriteLine("\r\nEnter X:");
            var entered = Console.ReadLine();
            int x = isInt(entered);

            Console.WriteLine("\r\nEnter Y:");
            entered = Console.ReadLine();
            int y = isInt(entered);

            Console.WriteLine("\r\nEnter Z:");
            entered = Console.ReadLine();
            int z = isInt(entered);

            var firstResult = (x + y) * (Math.Pow(z, 2) + 1);
            Console.WriteLine("\r\nFirst expression result: {0}", firstResult);

            var secondResult = (x%z - 1) * Math.Sqrt(y);
            Console.WriteLine("\r\nSecond expression result: {0}", secondResult);

            var thirdResult = ( x * y + y * z ) / Math.Pow(z, 3);
            Console.WriteLine("\r\nThird expression result: {0}", thirdResult);

            Console.WriteLine("\r\nThe end =)");
            Console.ReadLine();
        }
    }
}
