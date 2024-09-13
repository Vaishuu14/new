namespace MOQTestingExample.Services.Interfaces
{
    public interface IPrinterService
    {
        public bool IsPrinterAvailable();

        public void Print();
    }
}
