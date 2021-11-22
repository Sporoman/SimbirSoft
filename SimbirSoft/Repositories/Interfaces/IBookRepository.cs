using SimbirSoft.Models;
using System.Collections.Generic;

namespace SimbirSoft.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
    }
}
