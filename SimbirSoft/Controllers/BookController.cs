using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Models;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 4 - Контроллер, отвечающий за книгу
/// </summary>
namespace SimbirSoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        /// <summary>
        /// 4.1.1 GET для всех книг
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<BookDto> GetBooks()
        {
            return TestData.GetBooksList();
        }

        /// <summary>
        /// 4.1.2 GET для всех книг по id автора
        /// </summary>
        /// <returns></returns>
        [HttpGet("byAuthorID")]
        public IEnumerable<BookDto> GetBookByAuthorID(int id)
        {
            // Проверка на нулевой id 
            if (id == 0)
                return GetBooks();

            // Объявляем новый список для отбора необходимых книг
            var list = new List<BookDto>();

            foreach (var unit in TestData.GetBooksList())
                if (unit.AuthorID == id)
                    list.Add(unit);

            return list;
        }

        /// <summary>
        /// Часть 2.2; 2 - Возможность сделать запрос с сортировкой по автору, имени книги и жанру.
        /// </summary>
        /// <returns></returns>
        [HttpGet("sortBy")]
        public IEnumerable<BookDto> GetSortBook(string sortStr)
        {
            sortStr = sortStr.ToLower();

            switch(sortStr)
            {
                case "title" :  return TestData.GetBooksList().OrderBy(unit => unit.Title);
                case "author":  return TestData.GetBooksList().OrderBy(unit => unit.AuthorID);
                case "genre" :  return TestData.GetBooksList().OrderBy(unit => unit.Genre);

                default: return GetBooks();
            }
        }

        /// <summary>
        /// 4.2 POST добавляющий новую книгу.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddBook([FromBody] BookDto unit)
        {
            // Проверка на корректный ID автора
            var bookUnit = TestData.GetHumansList().FirstOrDefault(unitHuman => unitHuman.ID == unit.AuthorID);
            if (bookUnit == null)
                ModelState.AddModelError("authorID", "Error: заданного authorID не существует");

            if (ModelState.IsValid)
            {
                // При передаче ID игнорируется
                TestData.AddBookToList(new BookDto { Title = unit.Title, Genre = unit.Genre, AuthorID = unit.AuthorID });
                return Ok($"{unit.Title}, {unit.Genre}, {unit.AuthorID}.");
            }
            else
                return BadRequest(ModelState);
        }

        /// <summary>
        /// 4.3 DELETE удаляющий книгу.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public void DeleteBook(int id)
        {
            TestData.GetBooksList().RemoveAll(unit => unit.ID == id);
        }
    }
}
