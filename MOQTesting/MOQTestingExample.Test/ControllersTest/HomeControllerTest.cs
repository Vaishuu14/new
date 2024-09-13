using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQTestingExample.Test.ControllersTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidLargerNumber()
        {

            IPrinterServices printerServices = new MockPrinterServices();

            IEmailServices emailServices = new MockEmailServices();

            HomeController controller = new HomeController(printerServices, emailServices);

            int gussedNumber = 120;

            string expectedResult = "Wromg , Try Smaller Number ...";

            string result = controller.Index( gussedNumber );

            Assert.Equal(expectedResult, result);


        }



    }
}
