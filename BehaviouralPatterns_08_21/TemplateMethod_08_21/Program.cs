using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_08_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage tea = new Tea();
            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine();

            Beverage coffee = new Coffeee();
            Console.WriteLine("Making coffee");
            coffee.PrepareRecipe();

            Console.ReadLine();

        }
    }
}
