using MOQTestingExample.Services.Interfaces;

namespace MOQTestingExample.Services
{
    public class PrinterService : IPrinterService
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
