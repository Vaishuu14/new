using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_08_14
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pepperoni(new Onion(new Capsicum(new BasePizza())));
            pizza.Prepare();
            Console.ReadLine();
        }
    }
}
