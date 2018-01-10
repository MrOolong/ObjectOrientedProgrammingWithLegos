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
            var car1 = new Car ("Red", "Toyota");
            //car1.color = "Red";
            //car1.manufacturer = "Toyota";

            Console.WriteLine("Car 1 is a " + car1.color + " " + car1.manufacturer);

        }
    }

    public class Car
    {
        public Car (string _color, string _manufacturer)
        {
            this.color = _color;
            this.manufacturer = _manufacturer;
        }

        public string color { get; set; }
        public string manufacturer { get; set; }

    }
}
