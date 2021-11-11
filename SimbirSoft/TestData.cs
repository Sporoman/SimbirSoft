using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirSoft
{
    /// <summary>
    /// 2.2.3 - Класс для статичного списка данных
    /// </summary>
    public static class TestData
    {
        static public readonly List<HumanDto> _humanlist = new List<HumanDto>()
        {
            new HumanDto{ Surname = "Ульянов",  Name = "Владимир", Patronymic = "Ильич",    Birthday = "22.04.1870"},
            new HumanDto{ Surname = "Воронин",  Name = "Николай",  Patronymic = "Петрович", Birthday = "12.05.1963"},
            new HumanDto{ Surname = "Максимов", Name = "Андрей",   Patronymic = "Иванович", Birthday = "21.10.2000"}
        };

        static public readonly List<BookDto> _booklist = new List<BookDto>()
        {
            new BookDto{ Title = "Синее пламя",      Genre = "Фэнтези", Author = "Воронин Дмитрий Анатольевич"},
            new BookDto{ Title = "Хижина дяди Тома", Genre = "Роман",   Author = "Гарриет Бичер-Стоу"},
            new BookDto{ Title = "Плоды земли",      Genre = "Роман",   Author = "Кнут Гамсун"}
        };
    }
}
