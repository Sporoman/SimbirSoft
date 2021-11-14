using Microsoft.AspNetCore.Mvc;
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
        /// 4.1.1 Get для всех книг
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<BookDto> GetBooks()
        {
            return TestData.GetBooksList();
        }

        /// <summary>
        /// 4.1.2 Get для всех книг по id автора
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
    }
}
