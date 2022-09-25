using lab_ferhad_m4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_ferhad_m4.Services.Interface
{
    public interface ILibraryService<T> where T : BaseEntity
    {
        void Create( T entity);
        void Delete(string name);
        void Get(string filter);
        void GetAll();
        

    }
}
