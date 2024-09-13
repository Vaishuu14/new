using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //  1. using concatination for display with using parse method

            //    Console.WriteLine("Enter your First number : ");
            //    int a = int.Parse ( Console.ReadLine());
            //    Console.WriteLine("Enter your second number : ");
            //    int b = int.Parse(Console.ReadLine());
            //    int c = a + b;
            //    Console.WriteLine("Sum is : "+c);
            //    Console.ReadLine();

            // 2.Use another way to print

            //Console.WriteLine("\'Welcome new user\'");
            //Console.WriteLine("Enter your First name : ");
            //string s = Console.ReadLine();
            //Console.WriteLine("Enter your Last name : ");
            //string y = Console.ReadLine();
            //Console.WriteLine("Your Full name is : {0} {1}", s,y);
            //Console.ReadLine();

            // 3. to print string there are two ways -

            // 1)
            //string s ="\'Hello\' ";
            //Console.WriteLine(s);
            //Console.ReadLine();

            // 2)

            //string s = @"'Hello' ";
            //Console.WriteLine(s);
            //Console.ReadLine();

            //4.Explicit type conversion
            //e.g.1)

            //String s = "50";
            //String s1 = "60";

            //int sum = Convert.ToInt32(s) + Convert.ToInt32(s1);
            //Console.WriteLine("The sum is : " + sum);
            //Console.ReadLine();

            //e.g.2)

            float f1 = 20.20f;
            float f2 = 40.40f;

            int sum = Convert.ToInt32(f1) + Convert.ToInt32(f2);
            Console.WriteLine("The sum is : " + sum);
            Console.ReadLine();
            Console.WriteLine(  );


        }
    }
}
