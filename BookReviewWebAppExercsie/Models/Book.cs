using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Book()
        {
            this.Reviews = new List<Review>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.Reviews)
            {
                sb.AppendLine(item.Name);
                sb.AppendLine(item.TextContent);
            }
            return sb.ToString();
        }
    }
}
