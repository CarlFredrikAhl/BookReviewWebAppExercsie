using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required, Range(0.0, 10.0), Column(TypeName = "decimal(18, 1)")]
        public Decimal Rating { get; set; }
    }
}
