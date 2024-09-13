using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQTestingExample.Test.ServicesMock
{
    public class MockEmailServices : IEmailService
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
