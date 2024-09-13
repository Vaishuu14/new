using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherExample
{
    class Class1
    {

        private int[] data = new int[5];

        public int this[int index , bool squre]
        {
            set
            { 
                if (squre)
                    data[index] = (int)Math.Sqrt(value);
                else
                    data[index] = value;

            }
            get 
            {
                if (squre)
                    return data[index] * data[index];
                else
                    return data[index];

            }
        }



    }




     class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();

            c[0, false] = 4;
            c[1, true] = 8;
            c[2, false] = 5;
            c[3, false] = 6;
            c[4, false] = 2;

            Console.WriteLine(c[0 , true]);
            Console.WriteLine(c[1, false]);

            Console.ReadLine();


        }
    }
}
