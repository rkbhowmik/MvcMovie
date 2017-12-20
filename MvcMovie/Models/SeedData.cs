using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;


namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(MvcMovieContext context)
        {
            // Look for any movies.
            //if (context.Movie.Any())
            //{
            //    return; // DB has been seeded
            //}

            context.Movie.AddRange
                (
                    //new Movie
                    //{
                    //    Title = "Jab we met",
                    //    ReleaseDate = DateTime.Parse("2009-06-05"),
                    //    Genre = "Romantic",
                    //    Price = 29M,
                    //    Rating = "PG-13"
                    //},

                    //new Movie
                    //{
                    //    Title = "Father Figures",
                    //    ReleaseDate = DateTime.Parse("2017-06-05"),
                    //    Genre = "Comedy",
                    //    Price = 149M,
                    //    Rating = "PG-10"
                    //},
                    new Movie
                    {
                        Title = "Fathers",
                        ReleaseDate = DateTime.Parse("2017-06-05"),
                        Genre = "Comedy",
                        Price = 149M,
                        Rating = "PG-10"
                    }

                );
            context.SaveChanges();
        }
    }
}
