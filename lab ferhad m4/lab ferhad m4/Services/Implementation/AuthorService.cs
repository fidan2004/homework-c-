using lab_ferhad_m4.Database;
using lab_ferhad_m4.Models;
using lab_ferhad_m4.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_ferhad_m4.Services.Implementation
{
    public class AuthorService : ILibraryService<Author>
    {
        private Library<Author> library;
        public AuthorService()
        {
            library = new Library<Author>();
        }
        public void Create(Author entity)
        {
           library.Datas.Add(entity);
        }

        public void Delete(string name)
        {
          Author author = library.Datas.Find(x=>x.Name.ToLower().Trim() == name.ToLower().Trim());
            author.SoftDelete = true;
            GetAll();
        }

        public void Get(string filter)
        {
            try
            {
                Author author = library.Datas.Find(x => x.Name.Contains(filter.ToLower().Trim()) || x.Surname.Contains(filter.ToLower().Trim()));
                Console.WriteLine(author.Name + " " + author.Surname); // adin her hansi bir hissesin yazsam get edecek contains isletdiyimize gore
            }
            catch(Exception)
            {
                Console.WriteLine("author wasnt found");
            }
        }

        public void GetAll()
        {
            foreach(var author in library.Datas.Where(m=>m.SoftDelete=false))
              {
                Console.WriteLine(author.Name + " " + author.Surname);
            }
        }

       
    }
}
