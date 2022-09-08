using Department_Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Employee.Data
{
    public class Database
    {
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }
    }
}