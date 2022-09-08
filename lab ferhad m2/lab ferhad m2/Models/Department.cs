using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Employee.Models
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
