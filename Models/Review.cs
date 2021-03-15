using System;

namespace MovieReviews.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Guid MovieId { get; set; }
        public string Reviewer { get; set; }
        public int Stars { get; set; }
    }
}