using System;
using System.Collections.Generic;

namespace taskin_class_1
{
    internal class Program
    { 
         static void Main(string[] args)
    
        {
         
            
                Student student = new Student(1, 18, "FIDAN", "karimova", "IT");
                Student student1 = new Student(2, 19, "FIDAN", "karimova", "IT");
                Student student2 = new Student(3, 20, "FIDAN", "karimova", "IT");
                Student student3 = new Student(4, 12, "FIDAN", "karimova", "IT");

                List<Student> st = new List<Student>();
                st.Add(student1);
                st.Add(student2);
                st.Add(student3);
                foreach (var i in st)
                    Console.WriteLine(i);
            }

        }

    }

