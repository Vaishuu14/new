using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestingExample.Services.Interfaces;

namespace XUnitTestingExample.Test.MoqServices
{
    public class MockEmailServices : IEmailServiceProvider
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
