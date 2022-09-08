using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Employee.Models
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Admin()
        {
            Username = "admin123";
            Password = "1234";

        }
    }
}
