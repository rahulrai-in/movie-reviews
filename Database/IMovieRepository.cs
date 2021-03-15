using System;
using System.Threading.Tasks;
using MovieReviews.Models;

namespace MovieReviews.Database
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task<Movie> AddReviewToMovieAsync(Guid id, Review review);
    }
}