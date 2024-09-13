namespace ClassLibrary1
{
    public class Class1
    {
        public int salary;
        private string name;

        public int Increment { get; set; }
        private string WorkingDays { get; set; }


        public void EmployeeSalary()
        {
            Console.WriteLine("This is EmployeeSalary Method ....");
        }

        private void EmployeeDetails()
        {
            Console.WriteLine("This is EmployeeDetails Method ....");
        }

    }
}
