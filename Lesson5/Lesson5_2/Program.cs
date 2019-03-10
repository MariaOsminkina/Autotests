using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    public class Car
    {
        public string name;
        private CarPart[] parts;

        public Car(string name, CarPart[] parts)
        {
            this.name = name;
            this.parts = parts;
        }

        public int getPartsPrice ()
        {
            int price = 0;
            for (int i = 0; i < this.parts.Length; i++)
            {
                price += this.parts[i].getPrice();
            }

            return price;
        }
    }

    public class CarPart
    {
        private string name;
        private int price;

        public CarPart(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int getPrice()
        {
            return this.price;
        }
    }

    public class Calculator
    {
        private Car jeep = new Car("JEEP", new CarPart[2] { new CarPart("Wheel1", 123), new CarPart("Wheel2", 234) });
        private Car opel = new Car("OPEL", new CarPart[2] { new CarPart("Door", 111), new CarPart("Engine", 222) });

        public int getCarPartsPrice (string carName)
        {
            if (carName == jeep.name)
            {
                return jeep.getPartsPrice();
            }

            if (carName == opel.name)
            {
                return opel.getPartsPrice();
            }

            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\r\nEnter car name:");
            var entered = Console.ReadLine();

            int price = new Calculator().getCarPartsPrice(entered);

            Console.WriteLine("\r\nSumm of car parts of {0} = {1}", entered, price);

            Console.ReadLine();
        }
    }
}
