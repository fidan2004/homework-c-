using ConsoleApp1.Data;
using ConsoleApp1.Models;
using ConsoleApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            List<Employee> employees = new List<Employee>();
            Database database = new Database();
            List<Department> departments = new List<Department>();
            Admin admin = new Admin();
            int count = 0;
        Login: Console.WriteLine("Username");
            string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            bool permission = true;



            while (permission)
            {

                if (username == admin.Username && password == admin.Password)
                {
                    operations.CreateDepartment("IT", employees, database, departments);
                    operations.GetAllEmployes(database);
                    operations.CreateEmployee("Jale", "Qasimzade", 19, database, employees);
                    operations.CreateEmployee("Ruslan", "Ibrahimov", 22, database, employees);
                    operations.DeleteEmployee(database, "Jale Qasimzade");
                    operations.GetActiveEmployes(database);
                    operations.DeleteEmployee(database, "Ruslan Ibrahimov");

                    Console.WriteLine("-----");
                    operations.GetAllEmployes(database);
                }
                else
                {

                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("Your account is blocked");
                        permission = false;
                    }
                    else
                    {
                        goto Login;
                    }
                }
                return;
            }


        }
    }
}
