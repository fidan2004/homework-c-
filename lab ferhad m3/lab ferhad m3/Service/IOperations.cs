using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Service
{
    public interface IOperations
    {
        void CreateDepartment(string name, List<Employee> employees, Database database, List<Department> departments);
        void CreateEmployee(string name, string surname, int age, Database database, List<Employee> employees);
        void DeleteEmployee(Database database, string fullname);
        void GetActiveEmployes(Database database);
        void GetAllEmployes(Database database);
    }
}
