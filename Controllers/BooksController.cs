using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Models;
using BookApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.GetBooks();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _bookRepository.AddBook(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            _bookRepository.UpdateBook(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }
    }
}
