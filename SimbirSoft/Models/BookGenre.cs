using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirSoft.Models
{
    public class BookGenre
    {
        [ForeignKey("bookid")]
        public virtual int Book_Id { get; set; }
        [ForeignKey("genreid")]
        public virtual int Genre_Id { get; set; }

        public virtual Book Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
