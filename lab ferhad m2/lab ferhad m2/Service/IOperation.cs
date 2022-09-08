using Department_Employee.Data;
using Department_Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Employee.Service
{
    public interface IOperations
    {
        void CreateEmployee(string name, string surname, int age, Database database, List<Employee> employees);
        void CreateDepartment(string name, List<Employee> employees, Database database, List<Department> departments);
        void DeleteEmployee(string fullname, Database database);
        void GetAllEmployes(Database database);
        void GetActiveEmployes(Database database);
    }
}
