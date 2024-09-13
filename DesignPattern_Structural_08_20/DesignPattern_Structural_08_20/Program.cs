using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Structural_08_20
{
     class Program
    {
        private IPizza _pizza;
        private IBread _bread;

        public Program()
        {
            _pizza = new PizzaProvider();
            _bread = new BreadProvider();
        }

        public void GetVegPizza()
        {
            _pizza.GetVegPizza();
        }

        public void GetNonVegPizza()
        {
            _pizza.GetNonVegPizza();
        }

        public void GetGarlicBread()
        {
            _bread.GetGarlicBread();
        }

        public void GetCheesyGarlicBread()
        {
            _bread.GetCheesyGarlicBread();
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine("----- Client ordered Pizza -------");
            p.GetVegPizza();
            p.GetNonVegPizza();

            Console.WriteLine("----- Client ordered Bread -------");

            p.GetGarlicBread();
            p.GetCheesyGarlicBread();

            Console.ReadKey();

        }
    }
}
