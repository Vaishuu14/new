using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
     class Controller
    {
        
        static void Main(string[] args)
        {

            

            var obj1 = FileName.GetInstance;
            var obj2 = FileName.GetInstance;

            //obj1.log("Hello");

            if (obj1.Equals(obj2))
                Console.WriteLine("Objects are same for both...");

            Console.ReadLine();






            //var obj1 = Logger.GetInstance();
            //var obj2 = Logger.GetInstance();

            //obj1.log("Hello");

            //if(obj1.Equals(obj2))
            //    Console.WriteLine("Objects are same for both...");

            //Console.ReadLine();


        }




    }
}
