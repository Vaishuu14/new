using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
     class Program
    {
        static void Main(string[] args)
        {   //Do while loop 
            //String confirm;
            //do
            //{
            //    Console.WriteLine("Enter first number : ");
            //    int a = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter second number : ");
            //    int b = int.Parse(Console.ReadLine());

            //    int sum = a + b;
            //    Console.WriteLine(" The Sum is : {0}", sum);

            //    Console.WriteLine(" DO you want to continue");
            //    confirm = Console.ReadLine().ToLower();


            //} while (confirm == "yes");
            //Console.ReadLine();



            //for loop

            //for(int i = 0;i<= 10; i++)
            //{
            //    Console.WriteLine( i);
            //}

            //Console.ReadLine();





            //do while loop
            String confirm;

            do {
                Console.WriteLine("Enter Number");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("This is Even Number - " + num);
                }
                else
                {
                    Console.WriteLine("This is odd number - " + num);
                }

                Console.WriteLine( "Do u want to display again ?");
                confirm = Console.ReadLine().ToLower();

            } while (confirm == "yes");

            Console.ReadLine();








        }
    }
}
