using MOQTestingExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQTestingExample.Test.ServicesMock
{
    public class MockPrinterServices : IPrinterService
    {
        public bool IsPrinterAvailable()
        {
            return true;
        }

        public void Print()
        {
            //
        }

    }
}
