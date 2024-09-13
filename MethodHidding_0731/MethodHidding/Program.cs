using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidding
{

    class Parent
    {
        public void show()
        {
            Console.WriteLine("This is parent method ....");
        }

    }

    class Child : Parent
    {

        public void show()
        {
           // base.show();
            Console.WriteLine("This is child method ...");
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            //Child c = new Child();
            //c.show();

            Parent p = new Parent();
            p.show();

            Console.ReadLine();

        }
    }
}
