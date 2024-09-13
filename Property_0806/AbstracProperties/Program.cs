using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracProperties
{

   public abstract class Person
    {
         public abstract string FirstName { get; set; }
         public abstract string LastName { get; set; }

     }


    class Student : Person
    {

        private int _Age;
        private string _Contact;

        private string _FirstName;
        private string _LastName;

        public override string FirstName
        {
            set
            {
                  _FirstName = value;
               
            }
            get
            {
                return _FirstName;
             }
        }

        public override string LastName
        {
            set
            {
                _LastName = value;
            }
            get
            {
                return _LastName;
            }

        }

        public int Age
        {
            set
            {
                _Age = value;
            }
            get
            {
                return _Age;
            }
        }
        public string Contact
        {
            set
            {
                _Contact = value;
            }
            get
            {
                return _Contact;
            }
        }

        public override string ToString()
        {
            return " Fisrt Name is : " + _FirstName + ",\n Last Name is : " + _LastName + ", \n Age is : " + _Age + ",\n Contact Number is : " + _Contact;
        }



    }



     class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();

            s.FirstName ="Vaishnavi";
            s.LastName = "Shitole";
            s.Age = 23;
            s.Contact = "9069525151";

            Console.WriteLine("Student data is - \n***************************\n" + s);



            Console.ReadLine();

        }
    }
}
