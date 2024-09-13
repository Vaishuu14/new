﻿namespace ProxyPattern_08_21
{
    class Employee
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee(string name , string password , string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }
    }
}
