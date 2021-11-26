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
            //modelBuilder.Entity<Book>().ToTable("Book");
            //modelBuilder.Entity<Genre>().ToTable("Genre");

            //modelBuilder.Entity<BookGenre>().ToTable("book_genre");
            //modelBuilder.Entity<BookGenre>().HasNoKey();

            //    modelBuilder.Entity<Book>()
            //.HasMany(c => c.Genres)
            //.WithMany(p => p.Books)
            //.Map(m =>
            //{
            //    // Ссылка на промежуточную таблицу
            //    m.ToTable("book_genre");

            //    // Настройка внешних ключей промежуточной таблицы
            //    m.MapLeftKey("book_id");
            //    m.MapRightKey("genre_id");
            //});


            // modelBuilder.Entity<BookGenre>().HasKey(p => p.Book_Id);
            // modelBuilder.Entity<BookGenre>().HasKey(p => p.Genre_Id);

            modelBuilder.Entity<Book>().HasMany(b => b.Genre).WithMany(g => g.Book).UsingEntity(enty => enty.ToTable("book_genres"));

            //modelBuilder.Entity<Book>().Property(unit => unit.Genres).HasColumnName("genre");
            //modelBuilder.Entity<Genre>().Property(unit => unit.Books).HasColumnName("book");

            //modelBuilder.Entity<Book>().Property(unit => unit.Id).HasColumnName("id");
            //modelBuilder.Entity<Book>().Property(unit => unit.Name).HasColumnName("name");
            //modelBuilder.Entity<Book>().Property(unit => unit.AuthorId).HasColumnName("author_id");
        }

        public virtual DbSet<Book> Books   { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}
