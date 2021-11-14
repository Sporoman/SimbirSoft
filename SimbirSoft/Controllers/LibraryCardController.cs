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
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void AddCard(int humanID, int bookID)
        {
            // Проверка на неккоректный id человека
            var humanUnit = TestData.GetHumansList().FirstOrDefault(unit => unit.ID == humanID);
            if (humanUnit == null)
                return;

            // Проверка на неккоректный id книги
            var bookUnit = TestData.GetBooksList().FirstOrDefault(unit => unit.ID == bookID);
            if (bookUnit == null)
                return;

            // При добавлении ID игнорируется,
            // время выставляется автоматически текущее
            TestData.AddCardToList(new LibraryCardDto { Human = humanUnit, Book = bookUnit, DateOfGive = DateTimeOffset.Now });
        }
    }
}
