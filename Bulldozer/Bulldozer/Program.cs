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
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker ()
        {

        }

        public void Count (int number)
        {
            if (Total == null)
                Total = 0;

            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        public int Total { get; set; }
    }
}
