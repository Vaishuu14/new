using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestingExample.Controllers;
using XUnitTestingExample.Services.Interfaces;
using XUnitTestingExample.Test.MoqServices;

namespace XUnitTestingExample.Test.ControllersTest
{
    public class HomeControllerTest
    {

        [Fact]
        public void HomeController_Index_SmallestResult()
        {
            //IPrinterServiceProvider printer = new MockPrinterServices();
            //IEmailServiceProvider email = new MockEmailServices();

            Mock<IEmailServiceProvider> emailService = new Mock<IEmailServiceProvider>();
            emailService.Setup(x => x.IsEmailAvailable()).Returns(true);
            Mock<IPrinterServiceProvider> printerService = new Mock<IPrinterServiceProvider>();
            printerService.Setup(x => x.IsPrinterAvailable()).Returns(true);



            HomeController homeController = new HomeController(printerService.Object, emailService.Object);

            int gussedNumber = 120;

            string result = homeController.Index( gussedNumber );

            string expectedResult = " Wrong , Try with Smaller Number...";

            Assert.Equal( expectedResult, result );

        }


        [Fact]
        public void HomeController_Index_BiggestResult()
        {
            //IPrinterServiceProvider printer = new MockPrinterServices();
            //IEmailServiceProvider email = new MockEmailServices();

            Mock<IEmailServiceProvider> emailService = new Mock<IEmailServiceProvider>();
            emailService.Setup(x => x.IsEmailAvailable()).Returns(true);
            Mock<IPrinterServiceProvider> printerService = new Mock<IPrinterServiceProvider>();
            printerService.Setup(x => x.IsPrinterAvailable()).Returns(true);



            HomeController homeController = new HomeController(printerService.Object, emailService.Object);

            int gussedNumber = 80;

            string result = homeController.Index(gussedNumber);

            string expectedResult = "Wrong , Try with Bigger Number...";

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData(80 , "Wrong , Try with Bigger Number...")]
        [InlineData(180, " Wrong , Try with Smaller Number...")]
        [InlineData(100, "You Gussed Correct Number !")]
        public void HomeController_Index_ValidNumber(int number ,string expectedResult )
        {

            Mock<IEmailServiceProvider> emailService = new Mock<IEmailServiceProvider>();
            emailService.Setup(x => x.IsEmailAvailable()).Returns(true);
            Mock<IPrinterServiceProvider> printService = new Mock<IPrinterServiceProvider>();
            printService.Setup(x => x.IsPrinterAvailable()).Returns(true);

            HomeController controller = new HomeController(printService.Object, emailService.Object);


                int gussedNumber = number;

            string result = controller.Index(gussedNumber);

            Assert.Equal(expectedResult, result);
                



        }





    }
}
