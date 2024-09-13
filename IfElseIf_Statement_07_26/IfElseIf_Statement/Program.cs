using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIf_Statement
{
     class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your Percentage : ");
            //int percentage = int.Parse(Console.ReadLine());

            //if (percentage >= 80)
            //{
            //    Console.WriteLine("Grade : A1");
            //}
            //else if (percentage >= 70)
            //{
            //    Console.WriteLine( "Grade : A");
            //}
            //else if(percentage >= 55)
            //{
            //    Console.WriteLine( "Grade : B");
            //}
            //else if (percentage >= 45)
            //{
            //    Console.WriteLine("Grade : C");
            //}
            //else if (percentage >= 35)
            //{
            //    Console.WriteLine("Grade : D");
            //}
            // if (percentage < 35)
            //{
            //    Console.WriteLine("Grade : F(Fail)");
            //}


            Console.WriteLine("Enter Your Age : ");
            int Age = int.Parse(Console.ReadLine());

            if(Age >= 6 )
            {
                Console.WriteLine( "This Child fit in Playgroup . So take admission in UKG ..");
            }
           else if (Age >= 5 )
            {
                Console.WriteLine("This Child fit in Nursery . So take admission in LKG ..");
            }
            else if (Age >= 4 )
            {
                Console.WriteLine("This Child fit in LKG . So take admission in Nursery ..");
            }
             if (Age >= 3 )
            {
                Console.WriteLine("This Child fit in UKG . So take admission in playgroup ..");
            }



            Console.ReadLine();


        }
    }
}
