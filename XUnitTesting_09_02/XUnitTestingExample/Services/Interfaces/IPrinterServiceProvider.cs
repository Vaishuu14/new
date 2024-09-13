namespace XUnitTestingExample.Services.Interfaces
{
    public interface IPrinterServiceProvider
    {

        public bool IsPrinterAvailable();

        public void Print();
    }
}
