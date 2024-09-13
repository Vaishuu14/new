using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDLLExample
{
    public class Class1
    {

        public int EmployeeID;
        public int Salary;

        public string WorkingDays { get; set; }
        private int Increment {  get; set; }

        public void EmployeeDetails()
        {
            Console.WriteLine("This is EmployeeDetails Method ....");
        }

        private void SalaryDetails()
        {
            Console.WriteLine("This is SalaryDetails Method ...");
        }

    }
}
