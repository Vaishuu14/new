using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{


    class Person
    {
        // read / write properties
        
        private string _FirstName;
        private string _LastName;

        //auto implemented

        public int StdId { get; set; }



       // properties
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



    }
     class Program
    {
       
        static void Main(string[] args)
        {

            Person p = new Person();

            p.StdId = 42;
            p.FirstName = "Vaishu";
            p.LastName = "Shitole";

            Console.WriteLine(p.StdId );
            Console.WriteLine(p.FirstName);
           Console.WriteLine(p.LastName);
            Console.ReadLine();

        }
    }
}
