using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication
{
    internal class ObsoleteAttribute
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public void oldMethod()
        {
            Console.WriteLine("This is Old Method");
        }

        public void newMethod()
        {
            Console.WriteLine("This is New Method ");
        }


    }
}
