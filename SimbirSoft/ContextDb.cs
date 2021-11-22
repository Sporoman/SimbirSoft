using Microsoft.EntityFrameworkCore;
using SimbirSoft.Models;

namespace SimbirSoft
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
