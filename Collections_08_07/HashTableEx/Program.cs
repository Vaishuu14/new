using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableEx
{
     class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();

            ht.Add("Ename", "Vaishu");
            ht.Add("Eid", 1234);
            ht.Add("Role", "Developer");
            ht.Add("Email", "vaishu@gmail.com");
            ht.Add("Location", "Hyderabad");

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("****************************");

            foreach(object obj in ht.Values)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("****************************");

            foreach (object obj in ht.Keys)
            {
                Console.WriteLine(obj + " : " + ht[obj]);
            }

            Console.WriteLine("****************************");

            Console.WriteLine(ht.ContainsValue("Vaishu"));
            Console.WriteLine(ht.ContainsValue("shitole"));

            Console.WriteLine(ht.Count);


            Console.ReadLine();


        }
    }
}
