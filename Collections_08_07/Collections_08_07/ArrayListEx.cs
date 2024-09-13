using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_08_07
{

    class ArrayListEx
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            Console.WriteLine(al.Capacity);

            //Insert
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            al.Add(500);


            //check capacity
            Console.WriteLine(al.Capacity);

            foreach(object obj in al)
                Console.Write(obj + " ");

            Console.WriteLine();


            //Insert at middle of ArrayList
            al.Insert(3, 350);

            foreach (object obj in al)
                Console.Write(obj + " ");

            //To Remove object
            al.RemoveAt(3);

            Console.WriteLine();
            foreach (object obj in al)
                Console.Write(obj + " ");

            Console.ReadLine();





        }
    }
}
