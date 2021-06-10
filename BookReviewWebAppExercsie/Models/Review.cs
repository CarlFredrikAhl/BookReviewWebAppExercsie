using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewWebAppExercsie.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TextContent { get; set; }
        [Required]
        public int? BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public Decimal Rating { get; set; }
    }
}
