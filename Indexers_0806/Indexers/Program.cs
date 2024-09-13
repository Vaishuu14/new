using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{

    class Employees
    {

        private int[] Age = new int[5];
        public int this[int index]
        {

            set 
            {
                if (index >= 0 && index < Age.Length)
                {

                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value ..");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index ..");
                }

            }
            get 
            {
                return Age[index];

            }
        }


    }



     class Program
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees();

            emp[2] = 30;

            Console.WriteLine(emp[2]);
            Console.ReadLine();
        }
    }
}
