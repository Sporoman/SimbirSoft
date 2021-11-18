using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.Models
{
    /// <summary>
    /// 2.2.2 - Класс представления книги
    /// Часть 2.2; 1 - Добавлена валидация
    /// </summary>
    public class BookDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Не указано Название")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Не указан ID Автора")]
        // По идее это никогда не сработает, поскольку тип int не может содержать null - ему будет присвоено 0, но всё же ;)
        public int AuthorID { get; set; }
        [Required(ErrorMessage = "Не указан Жанр")]
        public string Genre { get; set; }
    }
}
