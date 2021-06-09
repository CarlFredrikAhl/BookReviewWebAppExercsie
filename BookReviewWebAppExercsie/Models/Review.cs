using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewWebAppExercsie.Models
{
    public class Review
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TextContent { get; set; }
    }
}
