using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
     class Program
    {
        static void Main(string[] args)
        {

            var myAssembly = Assembly.LoadFile(@"C:\Users\Austraxpc46\source\repos\ReflectionExample\DemoDLLExample\bin\Debug\DemoDLLExample.dll");
            var myType = myAssembly.GetType("DemoDLLExample.Class1");

            object myObject = Activator.CreateInstance(myType);

            Type properties = myObject.GetType();


            foreach (MemberInfo member in properties.GetProperties())
            {

                Console.WriteLine("This is the properties in the dll file : " + member.Name);

            }

            foreach (MemberInfo member in properties.GetFields())
            {

                Console.WriteLine("This is the fields in the dll file :  " + member.Name);

            }

            Console.ReadLine();



        }
    }
}
