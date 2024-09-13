using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Interpolation
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine( "Enter your First name : ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last name : ");
            String lastName = Console.ReadLine();

            String name = $"Your Full Name is : {firstName} {lastName}";
            Console.WriteLine(name);
            Console.ReadLine();

        }
    }
}
