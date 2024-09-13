using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{

    class NewClass
    {

        public int num;
        public string name;

        public static NewClass operator +(NewClass obj1 , NewClass obj2)
        {
            NewClass obj3 = new NewClass();

            obj3.num = obj1.num + obj2.num;
            obj3.name = obj1.name + " " + obj2.name;
           

            return obj3;
        }


    }

     class Program
    {

        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            obj1.num = 10;
            obj1.name = "Vaishu";

            NewClass obj2 = new NewClass();
            obj2.num = 200;
            obj2.name = "Shitole";

            NewClass obj3 = new NewClass();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.num);

            Console.ReadLine();


        }
    }
}
