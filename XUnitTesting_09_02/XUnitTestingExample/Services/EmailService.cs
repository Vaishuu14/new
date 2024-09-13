using XUnitTestingExample.Services.Interfaces;

namespace XUnitTestingExample.Services
{
    public class EmailService : IEmailServiceProvider
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
