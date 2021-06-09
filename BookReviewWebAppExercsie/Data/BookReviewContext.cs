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
    }
}
