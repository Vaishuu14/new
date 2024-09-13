using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setterGettter

{


    class Person
    {

        private String Name;
        private int Age;


        public void setName(String name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("Name is required ..");
            }
            else
            {
                this.Name = name;
            }

        }

        public void getName()
        {
            if (string.IsNullOrEmpty(Name) == true)
            {

            }
            else
            {

                Console.WriteLine("Your name is : " + Name);
            }
        }

        public void setAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
             
                Console.WriteLine("Age does not negative or zero");

            }
        }

        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your Age is : " + Age);
            }
            else
            {

                
            }
        }


    }


     class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.setName("Vaishu");
            p.getName();

            p.setAge(23);
            p.getAge();

            Console.ReadLine();
        }
    }
}
