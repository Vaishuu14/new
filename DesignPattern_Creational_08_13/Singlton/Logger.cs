using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    class Logger
    {
        private static Logger instance;

        private Logger() { }

        public void log(string message) { 
             
            Console.WriteLine(message);
        
        }


        public static Logger GetInstance()
        {

            if (instance == null)
                instance = new Logger();

            return instance;


        }



    }
}
