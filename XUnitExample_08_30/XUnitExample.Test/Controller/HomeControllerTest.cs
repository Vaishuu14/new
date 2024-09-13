using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitExample.Controllers;

namespace XUnitExample.Test.Controller
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidSmallerResult()
        {
            
            HomeController controller = new HomeController();

            string ExpectedResult = "You Gussed Smaller Number";

            int gussedNumber = 80;
            string result = controller.Index(gussedNumber);

                      
            Assert.Equal(ExpectedResult, result);

        }

        [Fact]
        public void HomeController_Index_ValidBiggerResult()
        {

            HomeController controller = new HomeController();

            string ExpectedResult = "You Gussed Bigger Number";

            int gussedNumber = 180;
            string result = controller.Index(gussedNumber);

            Assert.Equal(ExpectedResult, result);


        }

        [Fact]
        public void HomeController_Index_ValidCorrectResult()
        {
            HomeController controller = new HomeController();

            string ExpectedResult = "You Gussed Correct Number";

            int gussedResult = 100;
            string result = controller.Index(gussedResult);

            Assert.Equal(ExpectedResult, result);
        }

    }
}
