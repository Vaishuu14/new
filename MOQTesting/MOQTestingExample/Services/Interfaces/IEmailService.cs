namespace MOQTestingExample.Services.Interfaces
{
    public interface IEmailService
    {
        public bool IsEmailAvailable();

        public void SendEmail();
    }
}
