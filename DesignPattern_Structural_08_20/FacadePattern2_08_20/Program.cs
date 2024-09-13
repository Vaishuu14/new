using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern2_08_20
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order();
            order.PlaceOrder();
            Console.ReadLine();


        }
    }
}
