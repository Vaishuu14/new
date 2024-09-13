using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_08_14
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }

        public Address Address { get; set; }

        public Person Clone()
        {

            return new Person { Name = Name, Age = Age, BirthDate = BirthDate , Address =  Address};
        }



        public override string ToString()
        {
            return $"Name : {Name} , Age : {Age} , BirthDate : {BirthDate} , HouseNumber : {Address?.HouseNumber}";

        }

    }


   public class Address
    {
        public int HouseNumber { get; set; }

        public Address(int houseNumber)
        {
            this.HouseNumber = houseNumber;
        }
    }
}
