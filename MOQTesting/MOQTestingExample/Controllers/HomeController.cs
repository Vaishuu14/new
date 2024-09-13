using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOQTestingExample.Services.Interfaces;

namespace MOQTestingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IPrinterService printerService;
        private readonly IEmailService emailService;

        public HomeController(IPrinterService printerService, IEmailService emailService)
        {
            this.printerService = printerService;
            this.emailService = emailService;
        }

        [HttpGet("index/{gussedNumber}")]
        public string Index(int gussedNumber)
        {

            string result;

            if (gussedNumber < 100)
                result =  "Wrong , Try Bigger Number ...";
            else if (gussedNumber > 100)
                result = "Wromg , Try Smaller Number ...";
            else
                result= "You Gussed Correct Number ...";

            if (emailService.IsEmailAvailable())
                emailService.SendEmail();


            if (printerService.IsPrinterAvailable())
                printerService.Print();

            return result;

        }


    }
}
