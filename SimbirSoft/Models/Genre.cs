using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirSoft.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Book> Book { get; set; }

        public Genre()
        {
            Book = new List<Book>();
        }
    }
}
