using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XUnitTestingExample.Services.Interfaces;

namespace XUnitTestingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IEmailServiceProvider emailServiceProvider;
        private readonly IPrinterServiceProvider printerServiceProvider;

        public HomeController(IPrinterServiceProvider printerServiceProvider, IEmailServiceProvider emailServiceProvider)
        {
            this.printerServiceProvider = printerServiceProvider;
            this.emailServiceProvider = emailServiceProvider;

        }

        [HttpGet("index/{gussedNumber}")]
        public string Index(int gussedNumber)
        {
            string result;

            if (gussedNumber < 100)
                result = "Wrong , Try with Bigger Number...";
            else if (gussedNumber > 100)
                result = " Wrong , Try with Smaller Number...";
            else
                result = "You Gussed Correct Number !";

            if (emailServiceProvider.IsEmailAvailable())
                emailServiceProvider.SendEmail();

            if(printerServiceProvider.IsPrinterAvailable())
                printerServiceProvider.Print();

            return result;






        }




    }
}
