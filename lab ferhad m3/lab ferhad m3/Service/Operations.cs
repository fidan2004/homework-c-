using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Service
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

            Console.WriteLine($"{department.Name} was successfully created!!");

        }

        public void CreateEmployee(string name, string surname, int age, Database database, List<Employee> employees)
        {
            Employee employee = new Employee();
            employee.Fullname = name + " " + surname;
            employee.Age = age;
            employee.IsDeleted = false;
            employees.Add(employee);
            database.Employees = employees;

            Console.WriteLine($"{employee.Fullname} {employee.Age} was successfully created!!");
        }

        public void DeleteEmployee(Database database, string fullname)
        {
            Employee employee = database.Employees.Where(m => m.Fullname == fullname).FirstOrDefault();

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                employee.IsDeleted = true;
                Console.WriteLine($"{employee.Fullname} {employee.Age} is successfully deleted");
            }
        }

        public void GetActiveEmployes(Database database)
        {
            List<Employee> employees = database.Employees.Where(m => m.IsDeleted == false).ToList();

            if (employees.Count > 0)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Fullname);
                }
            }
            else
            {
                Console.WriteLine("No active employes");
            }

        }

        public void GetAllEmployes(Database database)
        {
            if (database.Employees != null)
            {
                List<Employee> employees = database.Employees.ToList();
                if (employees.Count > 0)
                {
                    foreach (var employee in employees)
                    {
                        Console.WriteLine(employee.Fullname);
                    }
                }
                else
                {
                    Console.WriteLine("No employes found");
                }
            }
            else
            {
                Console.WriteLine("No list found");
            }
        }
    }
}