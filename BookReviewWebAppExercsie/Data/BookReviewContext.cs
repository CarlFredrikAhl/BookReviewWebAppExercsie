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
                Description = "Written for J.R.R. Tolkien’s own children, The Hobbit met with instant critical acclaim when it was first published in 1937. Now recognized as a timeless classic, this introduction to the hobbit Bilbo Baggins, the wizard Gandalf, Gollum, and the spectacular world of Middle-earth recounts of the adventures of a reluctant hero, a powerful and dangerous ring, and the cruel dragon Smaug the Magnificent. The text in this 372-page paperback edition is based on that first published in Great Britain by Collins Modern Classics (1998), and includes a note on the text by Douglas A. Anderson (2001).",
                Date = new DateTime(2002, 08, 15),
            };
            Book book2 = new Book
            {
                BookId = 2,
                Title = "Harry Potter and the Sorcerer's Stone",
                Genre = "Fantasy",
                AuthorId = author2.AuthorId,
                Description = "Full of sympathetic characters, wildly imaginative situations, and countless exciting details, the first installment in the series assembles an unforgettable magical world and sets the stage for many high-stakes adventures to come.",
                Date = new DateTime(2003, 11, 01),
            };
            Book book3 = new Book
            {
                BookId = 3,
                Title = "The Girl with the Dragon Tattoo",
                Genre = "Thriller",
                AuthorId = author3.AuthorId,
                Description = "Harriet Vanger, a scion of one of Sweden’s wealthiest families disappeared over forty years ago. All these years later, her aged uncle continues to seek the truth. He hires Mikael Blomkvist, a crusading journalist recently trapped by a libel conviction, to investigate. He is aided by the pierced and tattooed punk prodigy Lisbeth Salander. Together they tap into a vein of unfathomable iniquity and astonishing corruption.",
                Date = new DateTime(2008, 09, 16),
            };
            Book book4 = new Book
            {
                BookId = 4,
                Title = "Gone girl",
                Genre = "Mystery",
                AuthorId = author4.AuthorId,
                Description = "One of the most critically acclaimed suspense writers of our time, New York Times bestseller Gillian Flynn takes that statement to its darkest place in this unputdownable masterpiece about a marriage gone terribly, terribly wrong. The Chicago Tribune proclaimed that her work “draws you in and keeps you reading with the force of a pure but nasty addiction.” Gone Girl’s toxic mix of sharp-edged wit and deliciously chilling prose creates a nerve-fraying thriller that confounds you at every turn.",
                Date = new DateTime(2014, 04, 22),
            };
            Book book5 = new Book
            {
                BookId = 5,
                Title = "The Midnight Library",
                Genre = "Fantasy",
                AuthorId = author5.AuthorId,
                Description = "Between life and death there is a library, and within that library, the shelves go on forever. Every book provides a chance to try another life you could have lived. To see how things would be if you had made other choices . . . Would you have done anything different, if you had the chance to undo your regrets?",
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
                BookId = book1.BookId,
                Rating = 4
            };
            Review review2 = new Review
            {
                ReviewId = 2,
                Name = "Zoe",
                TextContent = "I will never ever rate this lower than 10. BEAUTIFUL.",
                BookId = book2.BookId,
                Rating = 10
            };
            Review review3 = new Review
            {
                ReviewId = 3,
                Name = "Diane Wallace",
                TextContent = "Loved it! an interesting,mystery filled and very thrill-seeking storyline..was well written,nice movie also... (paperback!)",
                BookId = book3.BookId,
                Rating = 8
            };
            Review review4 = new Review
            {
                ReviewId = 4,
                Name = "NReads",
                TextContent = "yo Amy really did THAT",
                BookId = book4.BookId,
                Rating = 9
            };
            Review review5 = new Review
            {
                ReviewId = 5,
                Name = "Emily B",
                TextContent = "This was cute and the concept was great but unfortunately it really lacked some depth for me!",
                BookId = book5.BookId,
                Rating = 6
            };
            modelBuilder.Entity<Review>().HasData(review1);
            modelBuilder.Entity<Review>().HasData(review2);
            modelBuilder.Entity<Review>().HasData(review3);
            modelBuilder.Entity<Review>().HasData(review4);
            modelBuilder.Entity<Review>().HasData(review5);
        }
    }
}
