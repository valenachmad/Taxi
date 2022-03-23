using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasObjectTaxi
{
    class Taxi
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }

        private string ondutyyon()
        {
            return onduty ? "yes" : "no";
        }

        public void taxiinfo()
        {
            Console.WriteLine("driver name: {0}", drivername);
            Console.WriteLine("on duty: {0}", ondutyyon());
            Console.WriteLine("number of passenger: {0}", numpassenger);
        }
        public void pickuppassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", drivername);
        }
        public void dropoffpassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", drivername);
        }
    }
}
