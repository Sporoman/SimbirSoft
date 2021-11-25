using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.Models
{
    /// <summary>
    /// 2.2.2 - Класс представления книги
    /// Часть 2.2; 1 - Добавлена валидация
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано Название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан ID Автора")]
        public int AuthorId { get; set; }
    }
}
