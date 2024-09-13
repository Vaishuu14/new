using XUnitTestingExample.Services.Interfaces;

namespace XUnitTestingExample.Services
{
    public class PrinterService : IPrinterServiceProvider
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
