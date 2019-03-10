using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Rectangle
    {
        private int side1;
        private int side2;

        public Rectangle(int x, int y)
        {
            this.side1 = x;
            this.side2 = y;
        }
        
        public int AreaCalculator()
        {
            return this.side1 * this.side2; 
        }

        public int PerimeterCalculator()
        {
            return (this.side1 + this.side2)*2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int isInt(string value)
            {
                bool isCorrect = int.TryParse(value, out int res);
                if (!isCorrect)
                {
                    Console.WriteLine("\r\nIncorrect value. Integer is needed.");
                    Console.ReadLine();
                }
                return res;
            }


            Console.Clear();

            Console.WriteLine("\r\nEnter length:");
            var entered = Console.ReadLine();
            int x = isInt(entered);

            Console.WriteLine("\r\nEnter width:");
            entered = Console.ReadLine();
            int y = isInt(entered);

            Rectangle instance = new Rectangle(x, y);
            Console.WriteLine("\r\nRectangle area: {0}", instance.AreaCalculator());
            Console.WriteLine("\r\nRectangle perimeter: {0}", instance.PerimeterCalculator());

            Console.ReadLine();
        }
    }
}
