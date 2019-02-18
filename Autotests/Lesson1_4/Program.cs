using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\nEnter first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("\r\nEnter second string:");
            string secondString = Console.ReadLine();

            Console.WriteLine("\r\nEnter symbol:");
            char symbol = char.Parse(Console.ReadLine());

            string concatedString = firstString + secondString;
            int res = concatedString.LastIndexOf(symbol);
            Console.WriteLine("\r\nIndex of {0} in {1}: {2}", symbol, concatedString, res);

            Console.WriteLine("\r\nThe end =)");
            Console.ReadLine();

        }
    }
}
