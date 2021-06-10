using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookReviewWebAppExercsie.Models;

namespace BookReviewWebAppExercsie.Data
{
    public class BookReviewContext : DbContext
    {
        public BookReviewContext (DbContextOptions<BookReviewContext> options)
            : base(options)
        {
        }

        public DbSet<BookReviewWebAppExercsie.Models.Book> Book { get; set; }

        public DbSet<BookReviewWebAppExercsie.Models.Author> Author { get; set; }

        public DbSet<BookReviewWebAppExercsie.Models.Review> Review { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(c => c.Books)
                .WithOne(e => e.Author);
            modelBuilder.Entity<Book>()
                .HasMany(c => c.Reviews)
                .WithOne(e => e.Book);

            base.OnModelCreating(modelBuilder);

            Author author1 = new Author
            {
                AuthorId = 1,
                Name = "J.R.R. Tolkien"
            };
            Author author2 = new Author
            {
                AuthorId = 2,
                Name = "J.K. Rowling"
            };
            Author author3 = new Author
            {
                AuthorId = 3,
                Name = "Stieg Larsson"
            };
            Author author4 = new Author
            {
                AuthorId = 4,
                Name = "Gillian Flynn"
            };
            Author author5 = new Author
            {
                AuthorId = 5,
                Name = "Matt Haig"
            };
            modelBuilder.Entity<Author>().HasData(author1);
            modelBuilder.Entity<Author>().HasData(author2);
            modelBuilder.Entity<Author>().HasData(author3);
            modelBuilder.Entity<Author>().HasData(author4);
            modelBuilder.Entity<Author>().HasData(author5);

            Book book1 = new Book
            {
                BookId = 1,
                Title = "The Hobbit, or There and Back Again",
                Genre = "Classics",
                AuthorId = author1.AuthorId,
                //Author = author1,
                Date = new DateTime(2002, 08, 15),
            };
            Book book2 = new Book
            {
                BookId = 2,
                Title = "Harry Potter and the Sorcerer's Stone",
                Genre = "Fantasy",
                AuthorId = author2.AuthorId,
                //Author = author2,
                Date = new DateTime(2003, 11, 01),
            };
            Book book3 = new Book
            {
                BookId = 3,
                Title = "The Girl with the Dragon Tattoo",
                Genre = "Thriller",
                AuthorId = author3.AuthorId,
                //Author = author3,
                Date = new DateTime(2008, 09, 16),
            };
            Book book4 = new Book
            {
                BookId = 4,
                Title = "Gone girl",
                Genre = "Mystery",
                AuthorId = author4.AuthorId,
                //Author = author4,
                Date = new DateTime(2014, 04, 22),
            };
            Book book5 = new Book
            {
                BookId = 5,
                Title = "The Midnight Library",
                Genre = "Fantasy",
                AuthorId = author5.AuthorId,
                //Author = author5,
                Date = new DateTime(2020, 09, 29),
            };
            modelBuilder.Entity<Book>().HasData(book1);
            modelBuilder.Entity<Book>().HasData(book2);
            modelBuilder.Entity<Book>().HasData(book3);
            modelBuilder.Entity<Book>().HasData(book4);
            modelBuilder.Entity<Book>().HasData(book5);

            Review review1 = new Review
            {
                ReviewId = 1,
                Name = "Inge",
                TextContent = "Cool Story Bro",
                BookId = book1.BookId
            };
            Review review2 = new Review
            {
                ReviewId = 2,
                Name = "Zoe",
                TextContent = "I will never ever rate this lower than 5 stars. BEAUTIFUL.",
                BookId = book2.BookId
            };
            Review review3 = new Review
            {
                ReviewId = 3,
                Name = "Diane Wallace",
                TextContent = "Loved it! an interesting,mystery filled and very thrill-seeking storyline..was well written,nice movie also... (paperback!)",
                BookId = book3.BookId
            };
            Review review4 = new Review
            {
                ReviewId = 4,
                Name = "NReads",
                TextContent = "yo Amy really did THAT",
                BookId = book4.BookId
            };
            Review review5 = new Review
            {
                ReviewId = 5,
                Name = "Emily B",
                TextContent = "This was cute and the concept was great but unfortunately it really lacked some depth for me!",
                BookId = book5.BookId
            };
            modelBuilder.Entity<Review>().HasData(review1);
            modelBuilder.Entity<Review>().HasData(review2);
            modelBuilder.Entity<Review>().HasData(review3);
            modelBuilder.Entity<Review>().HasData(review4);
            modelBuilder.Entity<Review>().HasData(review5);
        }
    }
}
