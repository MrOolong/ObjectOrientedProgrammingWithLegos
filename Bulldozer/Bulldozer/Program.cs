using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozer("yellow", "Mini");

            var dozer2 = new BullDozer("red", "Large");
           
            Console.WriteLine("Bulldozer 1 is " + dozer.color);
            Console.WriteLine("Bulldozer 2 is " + dozer2.color);

        }
    }

    public class BullDozer
    {
        // directly below is the constructor
        public BullDozer(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }

        public string color { get; set; }
        public string size { get; set; }
    }
}
