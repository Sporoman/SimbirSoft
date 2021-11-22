using System;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.Models
{
    /// <summary>
    /// Часть 2.1; 1 - Новая сущность LibraryCard
    /// Часть 2.2; 1 - Добавлена валидация
    /// </summary>
    public class LibraryCardDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Не указан Человек")]
        public HumanDto Human { get; set; }
        [Required(ErrorMessage = "Не указана Книга")]
        public BookDto Book { get; set; }
        public DateTimeOffset DateOfGive { get; set; }
    }
}
