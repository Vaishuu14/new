using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Month No. to see which season is : ");
            int month = int.Parse(Console.ReadLine());

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine(" The "+month+" month is Winter month");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine(" The "+month+" th month is Summer month");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine(" The "+month+" month is Spring month");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine(" The  "+month+" month is fall month");
                    break;

                default:
                    Console.WriteLine( "Invalid month no");
                    break;

            }
            Console.ReadLine();


        }
    }
}
