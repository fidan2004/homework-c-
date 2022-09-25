using System;
using System.Collections.Generic;
using System.Text;

namespace lab_ferhad_m4.Models
{
    public class Book : BaseEntity
    {

        public int PageCount { get; set; }
        public Author author { get; set; }

        public Book(string name, int pageCount)
        {
            Name = name;
            PageCount = pageCount;
            SoftDelete = false;
            
        }
    }
}
