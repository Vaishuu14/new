using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_08_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp = new Employee("Vaishnavi", "Vaishu@123", "Intern");
            SharedFolderProxy proxy = new SharedFolderProxy(emp);
            proxy.PerformRWOperation();

            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp1 = new Employee("Vaishu", "vaishu123", "Manager");
            SharedFolderProxy proxy1 = new SharedFolderProxy(emp1);
            proxy1.PerformRWOperation();

            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role CEO to folderproxy");
            Employee emp2 = new Employee("Shitole", "shitole123", "CEO");
            SharedFolderProxy proxy2 = new SharedFolderProxy(emp2);
            proxy2.PerformRWOperation();








            Console.ReadLine();

        }
    }
}
