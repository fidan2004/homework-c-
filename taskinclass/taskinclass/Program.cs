using System;
using System.Collections.Generic;

namespace taskinclass
{
    public class Program
    {
        public static FilterEmployee emps = new FilterEmployee(); 
        static void Main(string[] args)
        { 

            SeedDateBase();
            while (true)
            { 
            Console.WriteLine("seciminizi edin");
           
            string textLine = Console.ReadLine();
            
            var commands = textLine.Split(" ");

                switch (commands[0])
                {
                    case "Badge":
                        FindByBadgeId(commands[1]);
                        break;
                    case "Name":
                        FindByName(commands[1]);
                        break;
                    case " Department":
                        FindDepartment(commands[1]);
                        break;
                    case "Add":
                        AddEmployee();
                            break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }

                    
            }

            static void FindByName(string name)
            {
                List<Employee> emp = emps.FindByName(name);
                emp.ForEach(x => x.FullName());

            }
            static void FindDepartment(string department )
            {

                if(Enum.TryParse(department,out Department dep))
                {
                    emps.FindByDepartment(dep);
                }
                List<Employee> emp = emps.FindByDepartment(dep);
                emp.ForEach(x => x.FullName());
            }



           static void FindByBadgeId(string id)
            {
                int a = int.Parse(id);
                Employee emp = emps.FindById(a);
                emp.FullName();
               
            }

            static void AddEmployee()
            {
                Console.Write("enter id");
                int id = int.Parse(Console.ReadLine());
                Console.Write("enter name");
                string name = Console.ReadLine();
                Console.Write("enter surname");
                string surname = Console.ReadLine();
                Console.Write("enter contactinfo");
                string contactinfo = Console.ReadLine();
                Console.Write("enter department");
                Department myDepartment = default;
                string dep = Console.ReadLine();
                if(Enum.TryParse(dep,out Department department))
                {
                    myDepartment = department;
                }
                Employee newEmployee = new Employee(id, name, surname, contactinfo, myDepartment);
                emps.AddNewEmployee(newEmployee);
                newEmployee.FullName();
            }



            static void SeedDateBase()
            {
                var emp1 = new Employee(123, "fidan", "karimova", "7777", Department.Baku);
                var emp2 = new Employee(124, "gulnar", "karimova", "7777", Department.Agstafa);
                var emp3 = new Employee(125, "lale", "karimova", "7777", Department.Ganja);
                var emp4 = new Employee(126, "gunay", "karimova", "7777", Department.Yevlax);
                emps.AddNewEmployee(emp1);
                emps.AddNewEmployee(emp2);
                emps.AddNewEmployee(emp3);  
                emps.AddNewEmployee(emp4);  
            }

        }
    }
}
