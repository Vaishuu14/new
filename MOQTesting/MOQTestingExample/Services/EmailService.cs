using MOQTestingExample.Services.Interfaces;

namespace MOQTestingExample.Services
{
    public class EmailService : IEmailService
    {
        public bool IsEmailAvailable()
        {
            return true;
        }

        public void SendEmail()
        {
           //
        }
    }
}
