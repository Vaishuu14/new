using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafeCode_08_09
{
     class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 10;
                int* pi = &i;

                Console.WriteLine("Value is : "+i);
                Console.WriteLine("Address is : "+(int)pi);
                Console.ReadLine();


            }




        }
    }
}
