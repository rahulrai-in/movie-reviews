using GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL.Types
{
    public sealed class MovieObject : ObjectGraphType<Movie>
    {
        public MovieObject()
        {
            Name = nameof(Movie);
            Description = "A movie in the collection";

            Field(m => m.Id).Description("Identifier of the movie");
            Field(m => m.Name).Description("Name of the movie");
            Field(
                name: "Reviews",
                description: "Reviews of the movie",
                type: typeof(ListGraphType<ReviewObject>),
                resolve: m => m.Source.Reviews);
        }
    }
}