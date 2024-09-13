using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{
    public delegate void Calculation(int a, int b);


     class Program
    {

        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The Addition of {0} and {1} is :  {2}", a, b, result);

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

        static void Main(string[] args)
        {

            Calculation cal = new Calculation(Addition);
            cal += Substraction;
            cal += Multiplication;
            cal += Division;

            cal(50, 20);

            Console.ReadLine();



        }
    }
}
