using GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL.Types
{
    public sealed class ReviewObject : ObjectGraphType<Review>
    {
        public ReviewObject()
        {
            Name = nameof(Review);
            Description = "A review of the movie";

            Field(r => r.Reviewer).Description("Name of the reviewer");
            Field(r => r.Stars).Description("Star rating out of five");
        }
    }
}