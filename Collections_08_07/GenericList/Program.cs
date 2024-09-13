using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{

    class Customers
    {

        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }

    }





     class Program
    {
        static void Main(string[] args)
        {


            Customers c1 = new Customers { CustId = 11, Name = "Vaishu",
                                           City = "Hyderabad", Balance = 12000.00 };

            Customers c2 = new Customers
            {
                CustId = 12,
                Name = "ABC",
                City = "Hyderabad",
                Balance = 12000.00
            };





            List<Customers> list = new List<Customers>();

            list.Add(c1);
            list.Add(c2);

            foreach (Customers c in list)
            {
                Console.WriteLine(c.Name + " " + c.CustId + " " + c.City + " " + c.Balance);
            }

            Console.ReadLine();



        }
    }
}
