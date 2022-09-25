using lab_ferhad_m4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_ferhad_m4.Database
{
    public class Library<T>
    {
        public List<T> Datas { get; set; }
        public Library()
        {
            Datas = new List<T>();  
        }
    }
}
