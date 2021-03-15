using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;

namespace MovieReviews.Database
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public Task<Movie> GetMovieByIdAsync(Guid id)
        {
            return _context.Movie.Where(m => m.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<Movie> AddReviewToMovieAsync(Guid id, Review review)
        {
            var movie = await _context.Movie.Where(m => m.Id == id).FirstOrDefaultAsync();
            movie.AddReview(review);
            await _context.SaveChangesAsync();
            return movie;
        }
    }
}