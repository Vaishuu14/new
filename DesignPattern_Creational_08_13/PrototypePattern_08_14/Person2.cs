using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_08_14
{
    public class Person2  : ICloneable
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }

        public Address Address { get; set; }

        public Object Clone()
        {

            return new Person2 { Name = Name, Age = Age, BirthDate = BirthDate, Address = new Address(Address.HouseNumber) };
        }



        public override string ToString()
        {
            return $"Name : {Name} , Age : {Age} , BirthDate : {BirthDate} , HouseNumber : {Address?.HouseNumber}";

        }


    }
}
