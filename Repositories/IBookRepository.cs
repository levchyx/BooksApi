using BookApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(int id, Book newBook);
        void Delete(int id);
    }
}
