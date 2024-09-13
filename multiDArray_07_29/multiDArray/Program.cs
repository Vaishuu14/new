using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Rectangular Array

            //    int[,] myArray = new int[3, 4]
            //    {
            //        { 32, 65, 12, 45 },
            //        { 67, 97, 39, 87 },
            //        { 89, 73, 24, 76 }

            //    };

            //    for (int i = 0; i < myArray.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < myArray.GetLength(1); j++)
            //        {
            //            Console.Write(myArray[i, j] + " ");


            //        }
            //        Console.WriteLine();
            //        Console.Write(" ------------------ ");
            //        Console.WriteLine();
            //    }
            //    Console.ReadLine();





            // jagged Array 

            int[][] myArray = new int[3][];

            myArray[0] = new[] { 65, 75, 92, 54, 12, 88 };
            myArray[1] = new[] { 34, 655, 27, 75, 90 };
            myArray[2] = new[] { 87, 94, 23, 454, 19, 67, 55, 97, 37, 70 };


            for (int i = 0; i< myArray.GetLength(0); i++)
            {
                for (int j = 0;j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]+" " );
                   
                }
                Console.WriteLine( );
                Console.WriteLine("------------------" );
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
