using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-1-11"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Book of Mormon Movie",
                        ReleaseDate = DateTime.Parse("2003-3-13"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-2-23"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 0.49M
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-4-15"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 4.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-4-15"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-4-15"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 4.99M
                    },

                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 1.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}