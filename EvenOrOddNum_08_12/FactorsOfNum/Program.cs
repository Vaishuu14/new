using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsOfNum
{
    class Program
    {
        public void Factor(int num)
        {
            for(int i =1; i<= num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine("Factor : " + i);
                
            }


        }
        //static void Main(string[] args)
        //{
        //    Program obj = new Program();
        //    Console.WriteLine("Enter num to check..");

        //    int i = int.Parse(Console.ReadLine());
        //    obj.Factor(i);
        //    Console.ReadLine();

        //}
    }
}
