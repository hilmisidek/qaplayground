using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace qaplayground.TestCase
{
    public class vehicle
    {
        //class constructor
        public String make { get; set; }
        public String model { get; set; }
        public String type { get; set; }

        public String color { get; set; }
        public String transmission { get; set; }
        public BigInteger seater { get; set; }

        public void vehicle_info() {
            Console.WriteLine("\nMake = " + this.make);
            Console.WriteLine("\nModel = " + this.model);
            Console.WriteLine("\nType = " + this.type);
            Console.WriteLine("\nColor = " + this.color);
            Console.WriteLine("\nTransmission = " + this.transmission);
            Console.WriteLine("\nSeater = " + this.seater);
        }
        
    }

}
