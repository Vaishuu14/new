using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_AS_Keyword
{
     class Program
    {
        static void Main(string[] args)
        {

            //IS keyword Example

            //object o = "vaishu";
            //bool check = o is string;
            //bool c = o is int;

            //Console.WriteLine(check);
            //Console.WriteLine(c);
            //Console.ReadLine();


            //AS Keyword Example

            object o = 123;

            string str = o as string; //Ans => vaishu

            //string str = o as string;   Ans =>    (null)
            Console.WriteLine(str);
            Console.ReadLine();




        }
    }
}
