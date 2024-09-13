using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_08_21
{
    class SharedFolder : ISharedFolder
    {
        public void PerformRWOperation()
        {
            Console.WriteLine("Performing Read Write Operation on shared folder..");
        }


    }
}
