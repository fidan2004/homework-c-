using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taskinclass
{
    public class FilterEmployee
    {
        List<Employee> employees = new List<Employee>();


                public Employee FindById(int id)
                  {

            return employees.Where(x => x.Id == id).FirstOrDefault();
                }


        public List<Employee> FindByName(string name)  
        {

            return employees.Where(x => x.Name == name).ToList();
        }

        public List<Employee> FindByDepartment(Department Departments)
        {
            return employees.Where(x => x.Departments == Departments).ToList();
}
        public void AddNewEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
