using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qaplayground.TestCase
{
    public class Car : vehicle
    {
        //class constructor
        public String entertainment_item { get; set; }
        public Boolean autopilot {  get; set; }
        public String seat_cover {  get; set; }

        public void car_info()
        {
            Console.WriteLine("\nEntertainment = " + this.entertainment_item);
            Console.WriteLine("\nAuto Pilot = " + this.autopilot);
            Console.WriteLine("\nSeat Cover = " + this.seat_cover);
            
        }


    }
}
