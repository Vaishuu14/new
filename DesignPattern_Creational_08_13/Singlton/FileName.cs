using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    class FileName
    {
       private static readonly Lazy<FileName> logger
            = new Lazy<FileName>(() => new FileName());

        private FileName() { }

        public void log(string message)
        {

            Console.WriteLine(message);

        }


        public static FileName GetInstance
        {
            get
            {
                return logger.Value;

            }

        }




    }
}
