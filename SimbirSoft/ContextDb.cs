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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Book>().Property(unit => unit.Id).HasColumnName("id");
            modelBuilder.Entity<Book>().Property(unit => unit.Name).HasColumnName("name");
            modelBuilder.Entity<Book>().Property(unit => unit.AuthorId).HasColumnName("author_id");
        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
