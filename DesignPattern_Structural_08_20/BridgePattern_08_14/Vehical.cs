using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_08_14
{
    public interface IEngine
    {
        string Refill();
    }

    public abstract class IVehical
    {
        protected IEngine engine;

        public IVehical(IEngine engine)
        {
            this.engine = engine;
        }

        public abstract void Refill();

    }

    public class Bike : IVehical
    {
        public Bike(IEngine engine) : base(engine)
        {
        }

        public override void Refill()
        {
            Console.WriteLine("Bike : " + engine.Refill());
        }

    }

    public class Car : IVehical
    {
        public Car(IEngine engine) : base(engine)
        {
        }

        public override void Refill()
        {
            Console.WriteLine("Car : " + engine.Refill());
        }

    }

    public class ElectricEngine : IEngine
    {
        public string Refill()
        {
            return "Charged to 100%";
        }
    }

    public class PetrolEngine : IEngine
    {
        public string Refill()
        {
            return "Refilied to 5 L ";
        }
    }

}
