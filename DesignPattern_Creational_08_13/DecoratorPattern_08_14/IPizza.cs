using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_08_14
{
    public interface IPizza
    {
        void Prepare();
    }

    public class BasePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Pizza is prepared ...");
        }
    }

    public abstract class PizaaDecorator : IPizza
    {
        public readonly IPizza _pizaa;

        protected PizaaDecorator(IPizza pizaa)
        {
            _pizaa = pizaa;
        }

        public virtual void Prepare()
        {
           _pizaa.Prepare();
        }

    }

    public class Pepperoni : PizaaDecorator
    {
        public Pepperoni(IPizza pizaa) : base(pizaa)
        {

        }
        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("Adding Pepperoni Topping");


        }
    }

    public class Onion : PizaaDecorator
    {
        public Onion(IPizza pizaa) : base(pizaa)
        {

        }
        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("Adding Onion Topping");


        }
    }

    public class Capsicum : PizaaDecorator
    {
        public Capsicum(IPizza pizaa) : base(pizaa)
        {

        }
        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("Adding Capsicum Topping");


        }
    }

}
