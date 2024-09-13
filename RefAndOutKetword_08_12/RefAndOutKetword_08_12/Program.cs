using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutKetword_08_12
{
     class Program
    {
        public void Calculation(int a , int b , ref int p , ref int q)
        {
            p = a + b;
            q = a * b;

        }


        public void Calculation1(int a, int b , out int p , out int q)
        {
            p = a + b;
            q = a * b;


        }



        static void Main(string[] args)
        {
            int a = 10, b = 20;
           int p = 0, q = 0;
            Program obj = new Program();
            obj.Calculation(a,b,ref p , ref q);
            Console.WriteLine(p +" "+q);

         //   int l , m;
            obj.Calculation1(a,b,out int l , out int m);
            Console.WriteLine(l + " " + m);


            Console.ReadLine();

        }
    }
}
