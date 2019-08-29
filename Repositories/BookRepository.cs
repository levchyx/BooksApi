using BookApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> _books = new List<Book>
            {
                new Book{Id = 1, Author = "First Author", Name = "First Book"},

                new Book{Id = 2, Author = "Second Author", Name = "Second Book"},

                new Book{Id = 3, Author = "Third Author", Name = "Third Book"},

                new Book{Id = 4, Author = "4 Author", Name = "4 Book"}
            };

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void UpdateBook(int id, Book newBook)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);

            var updated = new Book
            {
                Id = id,
                Author = string.IsNullOrEmpty(newBook.Author) ? book.Author : newBook.Author,
                Name = string.IsNullOrEmpty(newBook.Name) ? book.Name : newBook.Name
            };

            _books.Remove(book);

            _books.Add(updated);
        }

        public void Delete(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            _books.Remove(book);
        }
    }
}
