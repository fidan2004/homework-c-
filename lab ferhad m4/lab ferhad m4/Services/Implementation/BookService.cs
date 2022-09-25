using lab_ferhad_m4.Database;
using lab_ferhad_m4.Models;
using lab_ferhad_m4.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_ferhad_m4.Services.Implementation
{

    public class BookService : ILibraryService<Book>
    {
        private Library<Book> library;
        public BookService()
        {
            library = new Library<Book>();
        }
        public void Create(Book entity)
        {
            library.Datas.Add(entity);
        }

        public void Delete(string name)
        {
            Book book = library.Datas.Find(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
            book.SoftDelete = true;
            GetAll();


        }

        public void Get(string filter)
        {
            Book book = library.Datas.Find(v => v.Name.ToLower().Trim().Contains(filter.Trim().ToLower())
                 || v.author.Name.ToLower().Trim().Contains(filter.Trim().ToLower()) ||
                 v.author.Surname.ToLower().Trim().Contains(filter.Trim().ToLower()));
            Console.WriteLine(book.Name);

        }

        public void GetAll()
        {
            foreach(var book in library.Datas.Where(m=>m.SoftDelete=false))
            {
                Console.WriteLine(book.author.Name + " " + book.author.Surname + ":" + book.Name);
            }
                
        }
    }
}

