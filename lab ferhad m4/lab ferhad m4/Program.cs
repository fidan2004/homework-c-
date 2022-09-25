using lab_ferhad_m4.Models;
using lab_ferhad_m4.Services;
using lab_ferhad_m4.Services.Implementation;
using System;

namespace lab_ferhad_m4
{
    public class Program
    {
        static void Main(string[] args)
        {
            AuthorService authorService = new AuthorService();
            BookService bookService = new BookService();

            Author author1 = new Author("Lev", "Tolstoy", 55);
            Author author2 = new Author("Fyodor", "Dostoevski", 60);

            Book book1 = new Book("Anna Karenina", 800);
            Book book2 = new Book("Karamazov Brothers", 600);

            author1.Books.Add(book1);
            author2.Books.Add(book2);

            book1.author = author1;
            book2.author = author2;

            authorService.Create(author1);
            authorService.Create(author2);

            bookService.Create(book1);
            bookService.Create(book2);


            //create edenden sonra delete ede bilerem
            
            bookService.GetAll();
            authorService.GetAll();


        }
    }
}
