using System.ComponentModel.DataAnnotations;
using System;

namespace SimbirSoft.Models
{
    /// <summary>
    /// 2.2.1 - Класс представления пользователя
    /// Часть 2.2; 1 - Добавлена валидация
    /// </summary>
    public class HumanDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Не указана Фамилия")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Не указано Имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указано Отчество")]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Не указана Дата Рождения")]
        public DateTimeOffset Birthday { get; set; }
        public bool Writer { get; set; }
    }
}