using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookReviewWebAppExercsie.Data;
using BookReviewWebAppExercsie.Models;
using Microsoft.Data.SqlClient;

namespace BookReviewWebAppExercsie.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookReviewContext _context;

        public BooksController(BookReviewContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var bookReviewContext = _context.Book.Include(b => b.Author);
            return View(await bookReviewContext.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            List<Review> reviews = GetReviews(id);
            foreach (var review in reviews)
            {
                book.Reviews.Add(review);
            }
            return View(book);
        }


        public List<Review> GetReviews(int? id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookReviewContext-08fe1cae-53be-4606-97df-5410f058cc05;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand($"Select * from Review WHERE BookId = {id}", con);
            SqlCommand cmd2 = new SqlCommand($"Select * from Book WHERE BookId = {id}", con);
            List<Review> reviews = new List<Review>();
            using (con)
            {
                var book = new Book();
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                //while (rdr2.Read())
                //{
                //    book.BookId = (int)rdr["BookId"];
                    
                //}
                while (rdr.Read())
                {
                    var review = new Review();
                    review.Book = book;
                    review.ReviewId = (int)rdr["ReviewId"];
                    review.BookId = (int)rdr["BookId"];
                    review.Name = (string)rdr["Name"];
                    review.TextContent = (string)rdr["TextContent"];
                    review.Rating = (decimal)rdr["Rating"];
                    reviews.Add(review);
                }
            }

            return reviews;
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "Name");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,Title,Genre,AuthorId,Date")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,Title,Genre,AuthorId,Date")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.BookId == id);
        }
    }
}
