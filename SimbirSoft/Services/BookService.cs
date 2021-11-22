using SimbirSoft.Models;
using SimbirSoft.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirSoft.Services
{
    public class BookService
    {
        private IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> GetBooks()
        {
            return  _repository.GetBooks();
        }
    }
}
