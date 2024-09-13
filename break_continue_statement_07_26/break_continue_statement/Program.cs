using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue_statement
{
     class Program
    {
        static void Main(string[] args)
        {

            // continue
            //for(int i = 0; i < 10; i++)
            //{
            //    if(i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine( i);

            //}
            //Console.ReadLine();


            //break
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);

            }
            Console.ReadLine();


        }
    }
}
