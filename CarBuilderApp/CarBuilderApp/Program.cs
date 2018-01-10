using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate car1 object and define it's color and manufacturer
            var car1 = new Car
            {
                Color = "red",
                Manufacturer = "Toyota"
            };

            Console.WriteLine("car1 is a " + car1.Color + " " + car1.Manufacturer);
            Console.WriteLine();

            // instantiate the three SaloonCar objects and define their properties based on the 3 constructors
            var saloonCar1 = new SaloonCar (2);
            var saloonCar2 = new SaloonCar (3, "Nissan");
            var saloonCar3 = new SaloonCar (4, "purple", "Ford");

            Console.WriteLine("salooncar1 is a car with " + saloonCar1.NumberOfSeats + " seats.");
            Console.WriteLine("salooncar2 is a " + saloonCar2.Manufacturer + " with " + saloonCar2.NumberOfSeats + " seats.");
            Console.WriteLine("salooncar3 is a " + saloonCar3.Color + " " + saloonCar3.Manufacturer + " with " + saloonCar3.NumberOfSeats + " seats.");
            Console.WriteLine();
        }
    }

    public class Car
    {
        public Car ()
        {
        }

        public string Color { get; set; }
        public string Manufacturer { get; set; }

    }

    public class SaloonCar : Car
    {
        public SaloonCar (int _NumberOfSeats)
        {
            this.NumberOfSeats = _NumberOfSeats;
        }

        public SaloonCar (int _NumberOfSeats, string _manufacturer)
        {
            this.NumberOfSeats = _NumberOfSeats;
            this.Manufacturer = _manufacturer;
        }

        public SaloonCar (int _NumberOfSeats, string _color, string _manufacturer)
        {
            this.NumberOfSeats = _NumberOfSeats;
            this.Color = _color;
            this.Manufacturer = _manufacturer;
        }

        public int NumberOfSeats { get; set; } 
    }
}
