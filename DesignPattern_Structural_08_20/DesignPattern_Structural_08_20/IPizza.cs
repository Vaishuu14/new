using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Structural_08_20
{
    public interface IPizza
    {
        void GetVegPizza();
        void GetNonVegPizza();

    }

    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza..");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza..");
        }

        public void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Toppings");
        }
    }

    public interface IBread
    {
        void GetGarlicBread();
        void GetCheesyGarlicBread();
    }

    public class BreadProvider : IBread
    {
        public void GetCheesyGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread ..");
        }

        public void GetGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheese Garlic Bread..");
        }

        public void GetCheese()
        {
            Console.WriteLine("Getting Cheese..");
        }
    }




}
