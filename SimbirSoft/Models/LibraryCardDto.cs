using System;

namespace SimbirSoft.Models
{
    /// <summary>
    /// Часть 2.1; 1 - Новая сущность LibraryCard
    /// </summary>
    public class LibraryCardDto
    {
        public int ID { get; set; }
        public HumanDto Human { get; set; }
        public BookDto Book { get; set; }
        public DateTimeOffset DateOfGive { get; set; }
    }
}
