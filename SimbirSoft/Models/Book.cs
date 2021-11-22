using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.Models
{
    /// <summary>
    /// 2.2.2 - Класс представления книги
    /// Часть 2.2; 1 - Добавлена валидация
    /// </summary>
    public class Book
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Не указано Название")]
        public string name { get; set; }
        [Required(ErrorMessage = "Не указан ID Автора")]
        public int author_id { get; set; }
    }
}
