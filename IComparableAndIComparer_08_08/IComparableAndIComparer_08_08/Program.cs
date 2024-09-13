using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableAndIComparer_08_08
{
     class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { SId = 14, Name = "Vaishu", Class = 12, Marks = 150 };
            Student s2 = new Student() { SId = 16, Name = "Yogesh", Class = 12, Marks = 100 };
            Student s3 = new Student() { SId = 13, Name = "Shitole", Class = 12, Marks = 140 };
            Student s4 = new Student() { SId = 15, Name = "Nihar", Class = 12, Marks = 130 };
            Student s5 = new Student() { SId = 11, Name = "John", Class = 12, Marks = 150 };
            Student s6 = new Student() { SId = 17, Name = "peter", Class = 12, Marks = 155 };
            Student s7 = new Student() { SId = 12, Name = "Ali", Class = 12, Marks = 160 };


            List<Student> students = new List<Student> { s1, s2, s3, s4, s5, s6, s7 };

            CompareStudent std = new CompareStudent();

            students.Sort(std);

            foreach(Student s in students)
            {
                Console.WriteLine(s.SId + "  " + s.Name + " " + s.Class + "  " + s.Marks);
            }

            Console.ReadLine();


        }
    }
}
