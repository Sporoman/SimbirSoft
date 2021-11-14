namespace SimbirSoft.Models
{
    /// <summary>
    /// 2.2.2 - Класс представления книги
    /// </summary>
    public class BookDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string Genre { get; set; }
    }
}
