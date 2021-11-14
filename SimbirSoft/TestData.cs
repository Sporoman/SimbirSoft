using System.Collections.Generic;

namespace SimbirSoft
{
    /// <summary>
    /// 2.2.3 - Класс для статичного списка данных
    /// </summary>
    public static class TestData
    {
        static private List<HumanDto> _humansList = new List<HumanDto>()
        {
            new HumanDto{ Surname = "Ульянов",  Name = "Владимир", Patronymic = "Ильич",    Birthday = "22.04.1870"},
            new HumanDto{ Surname = "Воронин",  Name = "Николай",  Patronymic = "Петрович", Birthday = "12.05.1963"},
            new HumanDto{ Surname = "Максимов", Name = "Андрей",   Patronymic = "Иванович", Birthday = "21.10.2000"}
        };

        static private List<BookDto> _booksList = new List<BookDto>()
        {
            new BookDto{ Title = "Синее пламя",      Genre = "Фэнтези", Author = "Воронин Дмитрий Анатольевич"},
            new BookDto{ Title = "Хижина дяди Тома", Genre = "Роман",   Author = "Гарриет Бичер-Стоу"},
            new BookDto{ Title = "Плоды земли",      Genre = "Роман",   Author = "Кнут Гамсун"}
        };

        public static List<HumanDto> GetHumansList()
        {
            return _humansList;
        }

        public static void AddHumanToList(HumanDto unit)
        {
            _humansList.Add(unit);
        }
        public static List<BookDto> GetBooksList()
        {
            return _booksList;
        }

        public static void AddBookToList(BookDto unit)
        {
            _booksList.Add(unit);
        }
    }
}
