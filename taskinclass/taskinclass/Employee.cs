using System;
using System.Collections.Generic;
using System.Text;

namespace taskinclass
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactInfo { get; set; }
        public Department Departments { get; set; }
        public Employee(int id, string name, string surname, string contactInfo, Department department)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.ContactInfo = contactInfo;
            this.Departments = department;

        }
        public void FullName()
        {
            Console.WriteLine(Id  + Name   + Surname  + ContactInfo + Departments);
        }
    }
}
