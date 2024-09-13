using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_08_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Shallow CLoning
             Person p1 = new Person
             {
                 Name = "Vaishnavi",
                 Age = 22,
                 BirthDate = "2002-14-06" ,
                 Address = new Address(10)
             };

             Person p2 = p1.Clone();

             Here if we change name after cloning it not reflect in p2 object
             but for refernce proporty that is for address if i change housenumber to 12
             then it reflect in both objects . these is the drawback of shallow cloning 

             p1.Name = "Vaishu";
             p1.Address.HouseNumber = 12;
             Console.WriteLine(p1);

             Console.WriteLine(p2); */



            // Deep Clone 

            Person2 p1 = new Person2
            {
                Name = "Vaishnavi",
                Age = 22,
                BirthDate = "2002-14-06",
                Address = new Address(10)
            };

            Person2 p2 = (Person2)p1.Clone();

           p1.Name = "Vaishu";
           p1.Address.HouseNumber = 12;
            Console.WriteLine(p1);

            Console.WriteLine(p2);

            Console.ReadLine();


        }
    }
}
