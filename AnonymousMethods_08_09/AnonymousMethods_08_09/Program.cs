using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods_08_09
{
    public delegate string GreetingDelegate(string text);

     class Program
    {

        static void Main(string[] args)
        {

            GreetingDelegate obj = delegate (string name)
            {
                return "Hello " + name;

            };

            Console.WriteLine(obj.Invoke("Vaishu"));
            Console.ReadLine();


        }
    }
}
