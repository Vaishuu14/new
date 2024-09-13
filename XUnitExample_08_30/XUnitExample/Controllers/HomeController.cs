using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XUnitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index(int gussedNumber)
        {
            if (gussedNumber < 100)
                return "You Gussed Smaller Number";
            else if (gussedNumber > 100)
                return "You Gussed Bigger Number";
            else
                return "You Gussed Correct Number";

        }

        

    }
}
