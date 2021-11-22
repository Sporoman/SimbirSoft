using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbirSoft.Models;
using SimbirSoft.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 4 - Контроллер, отвечающий за книгу
/// </summary>
namespace SimbirSoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private BookService _service;
        
        public BookController(BookService service)
        {
            _service = service;
        }

        /// <summary>
        /// Перечисление для сортировки книг
        /// </summary>
        //    public enum SortBookEnum
        //    {
        //        Title  = 1,     // Название
        //        Author = 2,     // Автор
        //        Genre  = 3      // Жанр
        //    }

        /// <summary>
        /// 4.1.1 GET для всех книг
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Book> GetBooks()
        {
            return _service.GetBooks();
        }

        //    /// <summary>
        //    /// 4.1.2 GET для всех книг по id автора
        //    /// </summary>
        //    /// <returns></returns>
        //    [HttpGet("byAuthorID")]
        //    public IEnumerable<BookDto> GetBookByAuthorId(int id)
        //    {
        //        // Проверка на нулевой id 
        //        if (id == 0)
        //            return GetBooks();

        //        // Объявляем новый список для отбора необходимых книг с помощью linq
        //        var list = from unit in TestData.GetBooksList()
        //                   where unit.AuthorID == id
        //                   select unit;

        //        return list;
        //    }

        //    /// <summary>
        //    /// Часть 2.2; 2 - Возможность сделать запрос с сортировкой по автору, имени книги и жанру.
        //    /// </summary>
        //    /// <returns></returns>
        //    [HttpGet("sortBy")]
        //    public IEnumerable<BookDto> GetSortBook(SortBookEnum sortStr)
        //    {
        //        switch (sortStr)
        //        {
        //            case SortBookEnum.Title:  return TestData.GetBooksList().OrderBy(unit => unit.Title);
        //            case SortBookEnum.Author: return TestData.GetBooksList().OrderBy(unit => unit.AuthorID);
        //            case SortBookEnum.Genre:  return TestData.GetBooksList().OrderBy(unit => unit.Genre);

        //            // Просто возвращаем список книг, как он есть
        //            default: return GetBooks();
        //        }
        //    }

        //    /// <summary>
        //    /// 4.2 POST добавляющий новую книгу.
        //    /// </summary>
        //    /// <returns></returns>
        //    [HttpPost]
        //    public IActionResult AddBook([FromBody] BookDto unit)
        //    {
        //        // Проверка на корректный ID автора
        //        var bookUnit = TestData.GetHumansList().FirstOrDefault(unitHuman => unitHuman.ID == unit.AuthorID);
        //        if (bookUnit == null)
        //            return BadRequest($"Error: заданного authorID ({unit.AuthorID}) не существует.");

        //        // При передаче ID игнорируется
        //        TestData.AddBookToList(new BookDto { Title = unit.Title, Genre = unit.Genre, AuthorID = unit.AuthorID });
        //        return Ok($"{unit.Title}, {unit.Genre}, {unit.AuthorID}.");
        //    }

        //    /// <summary>
        //    /// 4.3 DELETE удаляющий книгу.
        //    /// </summary>
        //    /// <returns></returns>
        //    [HttpDelete]
        //    public void DeleteBook(int id)
        //    {
        //        TestData.GetBooksList().RemoveAll(unit => unit.ID == id);
        //    }
    }
}
