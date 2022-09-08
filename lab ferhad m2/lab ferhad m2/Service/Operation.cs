using Department_Employee.Data;
using Department_Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department_Employee.Service
{
    public class Operations : IOperations
    {
        public void CreateDepartment(string name, List<Employee> employees, Database database, List<Department> departments)
        {
            Department department = new Department();
            department.Name = name;
            department.Employees = employees;
            departments.Add(department);
            database.Departments = departments;


        }

        public void CreateEmployee(string name, string surname, int age, Database database, List<Employee> employees)
        {
            Employee employee = new Employee()
            {
                Fullname = name + " " + surname,
                Age = age,
                IsDelete = false
            };

            employees.Add(employee);
            database.Employees = employees;
        }

        public void DeleteEmployee(string fullname, Database database)
        {
            Employee employee = database.Employees.Where(m => m.Fullname == fullname).FirstOrDefault();

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            employee.IsDelete = true;
        }

        public void GetActiveEmployes(Database database)
        {
            List<Employee> employees = database.Employees.Where(m => m.IsDelete == false).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Fullname}");
            }
        }

        public void GetAllEmployes(Database database)
        {
            foreach (var employee in database.Employees)
            {
                Console.WriteLine($"{employee.Fullname}");
            }
        }
    }
}
