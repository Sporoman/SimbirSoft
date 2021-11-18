using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Часть 2.1; 2 - Контроллер, отвечающий за получение книги человеком
/// </summary>
namespace SimbirSoft.Controllers
{
    [ApiController]
    [Route("controller")]
    public class LibraryCardController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<LibraryCardDto> GetCards()
        {
            return TestData.GetCardsList();
        }

        /// <summary>
        /// Часть 2.1; 4 - POST отвечающий за взятие книги читателем
        /// Часть 2.2; 1 - Добавление валидации
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCard(int humanID, int bookID)
        {
            // Проверка на неккоректный id человека
            var humanUnit = TestData.GetHumansList().FirstOrDefault(unit => unit.ID == humanID);
            if (humanUnit == null)
                ModelState.AddModelError("humanUnit", "Error: humanUnit = null");

            // Проверка на неккоректный id книги
            var bookUnit = TestData.GetBooksList().FirstOrDefault(unit => unit.ID == bookID);
            if (bookUnit == null)
                ModelState.AddModelError("humanUnit", "Error: humanUnit = null");

            // При добавлении ID игнорируется,
            // время выставляется автоматически текущее
            if (ModelState.IsValid)
            {
                TestData.AddCardToList(new LibraryCardDto { Human = humanUnit, Book = bookUnit, DateOfGive = DateTimeOffset.Now });
                return Ok();
            }
            else
                return BadRequest(ModelState);
        }
    }
}
