using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_operation
{
     class Program
    {
        static void Main(string[] args)
        {
            String statement = "Hello , My name is Vaishnavi Shitole. I am doing job in silicon stack company";

            Console.WriteLine("The length of the statement is : " + statement.Length);


            // Console.WriteLine( "statement making upper case : " + statement.ToUpper());

            // Console.WriteLine("statement making lower case : " + statement.ToLower());

            // Console.WriteLine("Index of given character is : "+ statement.IndexOf("o"));

            int a = statement.IndexOf("S");
            String b = statement.Substring(a);
            Console.WriteLine(b);
            Console.WriteLine("Above Statement length is : "+b.Length);

            Console.ReadLine();



        }
    }
}
