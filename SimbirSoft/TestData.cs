using System.Collections.Generic;

namespace SimbirSoft
{
    /// <summary>
    /// 2.2.3 - Класс для статичного списка данных
    /// </summary>
    public static class TestData
    {
        // Переменные счётчики для ID
        static private int _idHuman = 7;
        static private int _idBook  = 4;

        static private List<HumanDto> _humansList = new List<HumanDto>()
        {
            new HumanDto{ ID = 1, Surname = "Ульянов",    Name = "Владимир", Patronymic = "Ильич",       Birthday = "22.04.1870", Writer = false },
            new HumanDto{ ID = 2, Surname = "Воронин",    Name = "Николай",  Patronymic = "Петрович",    Birthday = "12.05.1963", Writer = false },
            new HumanDto{ ID = 3, Surname = "Максимов",   Name = "Андрей",   Patronymic = "Иванович",    Birthday = "21.10.2000", Writer = false },

            new HumanDto{ ID = 4, Surname = "Воронин",    Name = "Дмитрий",  Patronymic = "Анатольевич", Birthday = "12.05.1980", Writer = true },
            new HumanDto{ ID = 5, Surname = "Бичер-Стоу", Name = "Гарриет",  Patronymic = "",            Birthday = "14.06.1811", Writer = true },
            new HumanDto{ ID = 6, Surname = "Гамсун",     Name = "Кнут",     Patronymic = "",            Birthday = "04.08.1859", Writer = true }
        };

        static private List<BookDto> _booksList = new List<BookDto>()
        {
            new BookDto{ ID = 1, Title = "Синее пламя",      Genre = "Фэнтези", AuthorID = 4 },
            new BookDto{ ID = 2, Title = "Хижина дяди Тома", Genre = "Роман",   AuthorID = 5 },
            new BookDto{ ID = 3, Title = "Плоды земли",      Genre = "Роман",   AuthorID = 6 }
        };

        public static List<HumanDto> GetHumansList()
        {
            return _humansList;
        }

        public static void AddHumanToList(HumanDto unit)
        {
            // Присваиваем ID записи и увеличиваем счётчик
            unit.ID = _idHuman;
            ++_idHuman;

            _humansList.Add(unit);
        }
        public static List<BookDto> GetBooksList()
        {
            return _booksList;
        }

        public static void AddBookToList(BookDto unit)
        {
            // Присваиваем ID записи и увеличиваем счётчик
            unit.ID = _idBook;
            ++_idBook;

            _booksList.Add(unit);
        }
    }
}
