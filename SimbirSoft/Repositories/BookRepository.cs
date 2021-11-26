using Microsoft.EntityFrameworkCore;
using SimbirSoft.Models;
using SimbirSoft.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft.Repositories
{
    public class BookRepository : IBookRepository
    {
        private ContextDb _contextDb;

        public BookRepository(ContextDb context)
        {
            _contextDb = context;
        }

        public Book AddBook(Book book)
        {


            return book;
        }

        public List<Book> GetBooks()
        {
            return _contextDb.Books.Include(b => b.Genre).ToList();
        }
    }
}
