using System;
using System.Collections.Generic;
using SimbirSoft.Models;

namespace SimbirSoft
{
    /// <summary>
    /// 2.2.3 - Класс для статичного списка данных
    /// </summary>
    public static class TestData
    {
        // Переменные-счётчики для ID
        static private int _idHuman = 7;
        static private int _idBook  = 4;
        static private int _idCard  = 1;

        static private List<HumanDto> _humansList = new List<HumanDto>()
        {
            new HumanDto{ ID = 1, Surname = "Ульянов",    Name = "Владимир", Patronymic = "Ильич",       Birthday = new DateTimeOffset(new DateTime(1870, 04, 22)), Writer = false },
            new HumanDto{ ID = 2, Surname = "Воронин",    Name = "Николай",  Patronymic = "Петрович",    Birthday = new DateTimeOffset(new DateTime(1963, 05, 12)), Writer = false },
            new HumanDto{ ID = 3, Surname = "Максимов",   Name = "Андрей",   Patronymic = "Иванович",    Birthday = new DateTimeOffset(new DateTime(2000, 10, 21)), Writer = false },
            new HumanDto{ ID = 4, Surname = "Воронин",    Name = "Дмитрий",  Patronymic = "Анатольевич", Birthday = new DateTimeOffset(new DateTime(1980, 05, 12)), Writer = true },
            new HumanDto{ ID = 5, Surname = "Бичер-Стоу", Name = "Гарриет",  Patronymic = "",            Birthday = new DateTimeOffset(new DateTime(1811, 06, 14)), Writer = true },
            new HumanDto{ ID = 6, Surname = "Гамсун",     Name = "Кнут",     Patronymic = "",            Birthday = new DateTimeOffset(new DateTime(1859, 08, 04)), Writer = true }
        }; 
        static private List<BookDto> _booksList = new List<BookDto>()
        {
            new BookDto{ ID = 1, Title = "Синее пламя",      Genre = "Фэнтези", AuthorID = 4 },
            new BookDto{ ID = 2, Title = "Хижина дяди Тома", Genre = "Роман",   AuthorID = 5 },
            new BookDto{ ID = 3, Title = "Плоды земли",      Genre = "Роман",   AuthorID = 6 }
        };

        /// <summary>
        /// Часть 2.1; 3 - Cтатичный список, отвечающий за хранение карт
        /// </summary>
        static private List<LibraryCardDto> _cardsList = new List<LibraryCardDto>();

        // -------------------------- Methods -------------------------- //

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

        public static List<LibraryCardDto> GetCardsList()
        {
            return _cardsList;
        }

        public static void AddCardToList(LibraryCardDto unit)
        {
            // Присваиваем ID записи и увеличиваем счётчик
            unit.ID = _idCard;
            ++_idCard;

            _cardsList.Add(unit);
        }
    }
}
