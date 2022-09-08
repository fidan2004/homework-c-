using Department_Employee.Data;
using Department_Employee.Models;
using Department_Employee.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            Database database = new Database();
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();

            operations.CreateEmployee("Ruslan", "Ibrahimov", 22, database, employees);
            operations.CreateEmployee("Jale", "Qasimzade", 19, database, employees);
            operations.CreateEmployee("Nicat", "Huseynli", 18, database, employees);

            Console.WriteLine("Employees");
            Console.WriteLine(" ");
            operations.GetAllEmployes(database);

            operations.CreateDepartment("Code Academy", employees, database, departments);

            Console.WriteLine("Department");
            Console.WriteLine(" ");
            foreach (var item in database.Departments)
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in database.Departments.Where(m => m.Name == "Code Academy"))
            {
                foreach (var employee in item.Employees)
                {
                    Console.WriteLine(employee.Fullname);
                }
            }



        }
    }
}