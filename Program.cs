using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasObjectTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object taxi
            Taxi taxi = new Taxi();

            //pengestan nilai propertis
            taxi.drivername = "Jono";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            //pemanggilan method
            taxi.taxiinfo();
            taxi.pickuppassenger();
            taxi.dropoffpassenger();

            Console.ReadKey();
        }
    }
}
