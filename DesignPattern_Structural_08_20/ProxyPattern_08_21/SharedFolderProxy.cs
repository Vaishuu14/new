using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_08_21
{
    class SharedFolderProxy :ISharedFolder
    {
        private ISharedFolder sharedFolder;
        private Employee employee;

        public SharedFolderProxy(Employee emp)
        {
            this.employee = emp;
        }

        public void PerformRWOperation()
        {

            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                sharedFolder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                sharedFolder.PerformRWOperation();
            }
            else
            {
                Console.WriteLine("Shared Folder Proxy say You dont have any permission to access this folder ..");

            }


        }


    }
}
