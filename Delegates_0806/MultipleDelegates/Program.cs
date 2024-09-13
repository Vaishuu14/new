using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDelegates
{
    public delegate int Calculation(int a, int b);
    public delegate int Calculation1(int a);
    public delegate void Calculation2(int a, int b);
    public delegate void show();

     class Program
    {

        public static int Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The Addition of {0} and {1} is :  {2}", a, b, result);
            return result;
        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The Subtraction of {0} and {1} is :  {2}", a, b, result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The Multiplication of {0} and {1} is :  {2}", a, b, result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("The Division of {0} and {1} is :  {2}", a, b, result);
        }

        public static int Squre(int a)
        {
            Console.WriteLine("The Squre of {0} is :  {1}", a, a * a);
            return a * a;
        }


        static void Main(string[] args)
        {

            //Calculation1 cal = new Calculation1(Squre);
            //cal(2);


            //Calculation cal = new Calculation(Addition);
            //cal(40, 20);


            Calculation2 cal = new Calculation2(Multiplication);
            cal(12, 2);


            Console.ReadLine();

        }
    }
}
