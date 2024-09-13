using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            //1st Way

            //String[] name = new string[4];

            //name[0] = "ABC";
            //name[1] = "DEF";
            //name[2] = "PQR";
            //name[3] = "XYZ";

            //Console.WriteLine(name[1]);

            //Console.ReadLine();


            //2nd way
            //int[] variables = new int[4] { 10,20,30,40};

            //3rd way

            // int[] var = { 10, 20, 30, 40 };

            //4th way

            //int[] var1 = new int[] {10,20,30,40 };


            //for each loop

            //int[] var = {50,4,63,2,4154,23};

            //foreach (int i in var)
            //{
            //    Console.WriteLine( i);
            //}



            //Sorting Array
            //int[] var = { 50, 4, 63, 2, 4154, 23 };

            //Array.Sort(var);

            //foreach (int i in var)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.ReadLine();


            //  Array Functions

            int[] num = { 10, 50, 60, 20 };
            Console.WriteLine( "The max number is : "+num.Max());
            Console.WriteLine( "The minimun number is : " + num.Min());
            Console.WriteLine( "The sum of all Array is : " + num.Sum());

            Console.ReadLine();

        }
    }
}
