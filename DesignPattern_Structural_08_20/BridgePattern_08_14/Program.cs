using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_08_14
{
    class Program
    {
        static void Main(string[] args)
        {

            IEngine engine = new ElectricEngine();
            IVehical vehical = new Bike(engine);

            vehical.Refill();
            // Console.WriteLine(vehical);
            Console.ReadLine();
        }
    }
}
