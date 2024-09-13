using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_08_21
{
   
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Breaw();
            PourInCup();
            AddCondiment();

        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup..");
        }

        protected abstract void Breaw();
        protected abstract void AddCondiment();

    }

    public class Tea : Beverage
    {

        protected override void Breaw()
        {

            Console.WriteLine("Steeping the Tea");


        }

        protected override void AddCondiment()
        {
            Console.WriteLine("Adding Leamon");
        }

    }

    public class Coffeee : Beverage
    {
        protected override void Breaw()
        {
            Console.WriteLine("Dropping coffee through filter");

        }
        protected override void AddCondiment()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }


}
