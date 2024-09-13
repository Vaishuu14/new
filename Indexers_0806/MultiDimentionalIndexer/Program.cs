using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentionalIndexer
{

    class MultiDimentionalIndexer
    {

         int[,] data = new int[3 , 3];

        public int this[int index1 , int index2]
        {
            set
            {
                data[index1, index2] = value;

            }
            get 
            {
                return data[index1, index2];

            }
        }

    }


     class Program
    {
        static void Main(string[] args)
        {
            MultiDimentionalIndexer multi = new MultiDimentionalIndexer();

            multi[0, 0] = 10;
            multi[0, 1] = 12;
            multi[0, 2] = 14;

            multi[1, 0] = 20;
            multi[1, 1] = 22;
            multi[1, 2] = 26;

            multi[2, 0] = 550;
            multi[2, 1] = 34;
            multi[2, 2] = 38;


            Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}",
                              multi[0, 0], multi[0, 1], multi[0, 2],
                              multi[1, 0], multi[1, 1], multi[1, 2],
                              multi[2, 0], multi[2, 1], multi[2, 2]
               );

            //Console.WriteLine(multi[0,2]);

            Console.ReadLine();



        }
    }
}
