using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerWithString
{


     class Program
    {
        private string[] name = new string[4];

        private string[] indices = { "username", "password", "email", "Book" };

        public string this[string index]
        {
            set
            {
                name[Array.IndexOf(indices, index)] = value;

            }
            get
            { 
              return name[Array.IndexOf(indices, index)];


            }
        }



        static void Main(string[] args)
        {

            Program p = new Program();
            p["username"] = "Vaishu@14";
            p["password"] = "12345678";
            p["email"] = "vaishushitole@gmail.com";
            p["Book"] = "C Sharp";


            Console.WriteLine("Your Data is - \nUser Name is : {0}\nPassword is : {1}\nEmail is : {2}\nBook Name is : {3}",
                               p["username"], p["password"], p["email"], p["Book"]);
            Console.ReadLine();
        }
    }
}
