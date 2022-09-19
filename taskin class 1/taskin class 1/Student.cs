using System;
using System.Collections.Generic;
using System.Text;

namespace taskin_class_1
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }    
        public string Name { get; set; }    
        public string Surname { get; set; } 

        public string faculty { get; set; } 

        public Student(int id, int age, string name, string surname, string faculty)
        {
            Id = id;
            Age = age;
            Name = name;
            Surname = surname;
            this.faculty = faculty;
        }
        public override string ToString()
        {
            return Id + Age + Name + Surname + faculty;
        }
    }
}
