using System;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;

namespace MovieReviews.Database
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().OwnsMany(m => m.Reviews).HasData(
                new Review
                {
                    Id = 1,
                    Reviewer = "A",
                    Stars = 4,
                    MovieId = new Guid("72d95bfd-1dac-4bc2-adc1-f28fd43777fd")
                },
                new Review
                {
                    Id = 2,
                    Reviewer = "B",
                    Stars = 5,
                    MovieId = new Guid("72d95bfd-1dac-4bc2-adc1-f28fd43777fd")
                },
                new Review
                {
                    Id = 3,
                    Reviewer = "A",
                    Stars = 4,
                    MovieId = new Guid("c32cc263-a7af-4fbd-99a0-aceb57c91f6b")
                },
                new Review
                {
                    Id = 4,
                    Reviewer = "D",
                    Stars = 5,
                    MovieId = new Guid("c32cc263-a7af-4fbd-99a0-aceb57c91f6b")
                },
                new Review
                {
                    Id = 5,
                    Reviewer = "E",
                    Stars = 3,
                    MovieId = new Guid("c32cc263-a7af-4fbd-99a0-aceb57c91f6b")
                },
                new Review
                {
                    Id = 6,
                    Reviewer = "F",
                    Stars = 5,
                    MovieId = new Guid("c32cc263-a7af-4fbd-99a0-aceb57c91f6b")
                },
                new Review
                {
                    Id = 7,
                    Reviewer = "A",
                    Stars = 2,
                    MovieId = new Guid("7b6bf2e3-5d91-4e75-b62f-7357079acc51")
                },
                new Review
                {
                    Id = 8,
                    Reviewer = "B",
                    Stars = 1,
                    MovieId = new Guid("7b6bf2e3-5d91-4e75-b62f-7357079acc51")
                },
                new Review
                {
                    Id = 9,
                    Reviewer = "G",
                    Stars = 3,
                    MovieId = new Guid("7b6bf2e3-5d91-4e75-b62f-7357079acc51")
                },
                new Review
                {
                    Id = 10,
                    Reviewer = "H",
                    Stars = 4,
                    MovieId = new Guid("7b6bf2e3-5d91-4e75-b62f-7357079acc51")
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = new Guid("72d95bfd-1dac-4bc2-adc1-f28fd43777fd"),
                    Name = "Superman and Lois"
                },
                new Movie
                {
                    Id = new Guid("c32cc263-a7af-4fbd-99a0-aceb57c91f6b"),
                    Name = "Game of Thrones"
                },
                new Movie
                {
                    Id = new Guid("7b6bf2e3-5d91-4e75-b62f-7357079acc51"),
                    Name = "Avengers: Endgame"
                }
            );
        }
    }
}