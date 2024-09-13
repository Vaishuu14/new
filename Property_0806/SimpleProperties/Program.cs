using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProperties
{

    class Person
    {
        private string _FirstName;
        private string _LastName;
        private int _Age;

        public string FirstName
        {
            set
            {
                this._FirstName = value;


            }
            get
            {
                return this._FirstName;
            }

        }

        public string LastName
        {
            set
            {
                this._LastName = value;
            }
            get
            {
                return this._LastName;
            }
        }

        public int Age
        {
            set
            {
                this._Age = value;

            }
            get
            {
                return this._Age;
            }
        }

        public override string ToString()
        {

            return "First Name is : " + this._FirstName + ", \nLast Name is : " + this._LastName + " ,\nAge is : " + this._Age;
        }


    }


     class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.FirstName = "Vaishnavi";
            p.LastName =  "Shitole";
            p.Age = 23;

            Console.WriteLine(p);
            Console.ReadLine();

        }
    }
}
