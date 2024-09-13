using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ITechCompany
    {
         void ShowDetails();
    }

    public interface ICarCompany
    {
        void ShowDetails();
    }

    public class Asus : ITechCompany
    {
        public void ShowDetails()
        {

            Console.WriteLine("I am from Asus TechCompany..");

        }
    }

    public class Dell : ITechCompany
    {
        public void ShowDetails()
        {
            Console.WriteLine("I am from Dell TechCompany ...");
        }

    }

    public class Tata : ICarCompany
    {

        public void ShowDetails()
        {
            Console.WriteLine("I am from Tata car company");
        }
    }


    public class Benz : ICarCompany
    {

        public void ShowDetails()
        {
            Console.WriteLine("I am from Benz car company");

        }
    }

    public interface AbstractFactory
    {
        ITechCompany techCompany();
        ICarCompany carCompany();

    }

    public class CompanyA : AbstractFactory
    {

        public ITechCompany techCompany()
        {
            return new Asus();
        }

        public ICarCompany carCompany()
        {
            return new Tata();
        }

    }

    public class CompanyB : AbstractFactory
    {
        public ITechCompany techCompany()
        {
            return new Dell();
        }

        public ICarCompany carCompany()
        {
            return new Benz();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            CompanyA obj1 = new CompanyA();
            var tech1 =  obj1.techCompany();
            var car1 = obj1.carCompany();
            tech1.ShowDetails();
            car1.ShowDetails();

            Console.WriteLine("-----------------");

            CompanyB obj2 = new CompanyB();
            var tech2 = obj2.techCompany();
            var car2 = obj2.carCompany();

            tech2.ShowDetails();
            car2.ShowDetails();

            Console.ReadLine();



        }
    }
}
