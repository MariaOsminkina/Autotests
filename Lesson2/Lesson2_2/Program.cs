using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt(string value)
            {
                bool isCorrect = int.TryParse(value, out int res);
                if (!isCorrect)
                {
                    Console.WriteLine("\r\nIncorrect value. Integer is needed.");
                    Console.ReadLine();
                }
                return isCorrect;
            }

            Console.Clear();

            Console.WriteLine("\r\nEnter first operand:");
            var entered = Console.ReadLine();
            if (!isInt(entered)) { return; }
            int first = int.Parse(entered);

            Console.WriteLine("\r\nEnter second operand:");
            entered = Console.ReadLine();
            if (!isInt(entered)) { return; }
            int second = int.Parse(entered);

            Console.WriteLine("\r\nEnter operation symbol:");
            entered = Console.ReadLine();

            switch (entered.ToUpper())
            {
                case "*":
                    Console.WriteLine("\r\nResult: {0}", first * second);
                    break;
                case "/":
                    Console.WriteLine("\r\nResult: {0}", first / second);
                    break;
                case "-":
                    Console.WriteLine("\r\nResult: {0}", first - second);
                    break;
                case "+":
                    Console.WriteLine("\r\nResult: {0}", first + second);
                    break;
                case "^":
                    Console.WriteLine("\r\nResult: {0}", Math.Pow(first, second));
                    break;
                default:
                    Console.WriteLine("\r\nIncorrect operation symbol. +-*/^ are allowed.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
