using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_08_09
{
    class Program
    {
        public void Greeting()
        {
            lock (this)
            {
                Console.WriteLine("I am : "+Thread.CurrentThread.Name);
                Console.Write("Hello ....");
                Thread.Sleep(1000);
                Console.WriteLine("User Welcome ");
            }

        }




        //public static void Function1()
        //{
        //   for (int i = 1; i <= 50; i++){
        //        Console.WriteLine("Function1 : " + i);
        //    }
        //}

        //public static void Function2()
        //{
        //    for (int i = 1; i <= 50; i++)
        //    {
        //        Console.WriteLine("Function2 : " + i);
        //        if (i == 25)
        //        {
        //            Console.WriteLine("Thread is going to stope for 8 sec ..");
        //            Thread.Sleep(8000);
        //        }
        //    }
        //}

        //public static void Function3()
        //{
        //    for (int i = 1; i <= 50; i++)
        //    {
        //        Console.WriteLine("Function3 : " + i);
        //    }
        //}




        static void Main(string[] args)
        {

            Program p = new Program();

            Thread t1 = new Thread(p.Greeting);
            Thread t2 = new Thread(p.Greeting);
            Thread t3 = new Thread(p.Greeting);

            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t3.Name = "Thread 3";

            t1.Start();t2.Start();t3.Start();

            Console.ReadLine();
















            //Thread t1 = new Thread(Function1);
            //Thread t2 = new Thread(Function2);
            //Thread t3 = new Thread(Function3);

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //Console.ReadLine();












        //    Thread t =  Thread.CurrentThread;
        //    t.Name = "Main Thread ...";

        //    Console.WriteLine("Current Executing Thread is : "+ Thread.CurrentThread.Name);
        //    Console.ReadLine();

        }
    }
}
