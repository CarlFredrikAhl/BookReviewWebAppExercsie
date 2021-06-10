using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewWebAppExercsie.Models
{
    public class Book
    {
        public int BookId { get; set; }
        
        [Required]
        public string Title { get; set; }
       
        [Required]
        public string Genre { get; set; }
        [Required]
        public int? AuthorId { get; set; }

        public Author Author { get; set; }

        [Required]
        public DateTime Date { get;  set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
