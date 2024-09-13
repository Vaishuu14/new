using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority_08_09
{
     class Program
    {
        static long count1 , count2 ;

        public static void Increment1()
        {
            while (true)
            {
                count1 += 1;

            }
        }

        public static void Increment2()
        {
            while (true)
            {
                count2 += 1;

            }
        }



        static void Main(string[] args)
        {

            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;


            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread is going to sleep ... ");
            Thread.Sleep(1000);
            Console.WriteLine("Main thread woke up ..");

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("Count 1 : "+count1);
            Console.WriteLine("Count 2 : "+count2);

            Console.ReadLine();







        }
    }
}
