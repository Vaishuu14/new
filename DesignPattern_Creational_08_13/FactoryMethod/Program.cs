using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface ICar
    {
        void Start();
    }

    class FourSeater : ICar
    {
        public void Start() { }

    }

    class SixSeater : ICar
    {
        public void Start() { }
    }
    public class CarFactory
    {
        public ICar GetCar(string car)
        {
            switch (car)
            {
                case "FourSeater":
                    return new FourSeater();

                case "SixSeater":
                    return new SixSeater();

            }

            return null;
        }



    }

     class Program
    {
        static void Main(string[] args)
        {

            CarFactory factory = new CarFactory();

            ICar fourSeater = factory.GetCar("FourSeater");
            ICar sixSeater = factory.GetCar("SixSeater");

            Console.ReadLine();



        }
    }
}
