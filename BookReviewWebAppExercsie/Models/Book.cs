using Microsoft.Data.SqlClient;
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

        public decimal AverageRating
        {
            get { return CalculateAverageRating(this.BookId); }
        }
        public int AmountOfReviewsDisplay
        {
            get { return AmountOfReviews(this.BookId); }
        }

        public Book()
        {
            this.Reviews = new List<Review>();
        }

        public int AmountOfReviews(int? id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookReviewContext-08fe1cae-53be-4606-97df-5410f058cc05;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand($"Select Rating from Review WHERE BookId = {id}", con);
            int count = 0;
            using (con)
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    count++;
                }
            }
            return count;
        }

        public decimal CalculateAverageRating(int? id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookReviewContext-08fe1cae-53be-4606-97df-5410f058cc05;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand($"Select Rating from Review WHERE BookId = {id}", con);

            decimal averageRating = 0;
            int count = 0;
            using (con)
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    averageRating += (decimal)rdr["Rating"];
                    count++;
                }
            }
            averageRating = averageRating / count;
            return averageRating;
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
