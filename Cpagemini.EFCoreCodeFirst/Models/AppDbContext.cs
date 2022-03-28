using Microsoft.EntityFrameworkCore;
using System;

namespace Cpagemini.EFCoreCodeFirst.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=arun-pc\sqlexpress; Database=CapgeminiNCA12; Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            modelBuilder.Entity<Book>(b =>
            {
                b.Property<DateTime>(x => x.AddedDate)
                .HasColumnType("date")
                .HasColumnName("AddedDate")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
            });

            //Many to Many Relationship - Books
            modelBuilder.Entity<BookAuthor>()
                 .HasOne(b => b.Book)
                 .WithMany(b => b.BooksAuthors)
                 .HasForeignKey(b => b.BookId);

            //Many to Many Relationship - Author
            modelBuilder.Entity<BookAuthor>()
                .HasOne(a => a.Author)
                .WithMany(a => a.BooksAuthors)
                .HasForeignKey(a => a.AuthorId);
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<BookAuthor> BooksAuthors { get; set; }
    }
}
