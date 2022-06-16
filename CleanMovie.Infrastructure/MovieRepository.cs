using CleanMovie.Application;
using CleanMovie.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie {Id = 1, Name = "Vickings", Cost = 3 },
            new Movie {Id = 2, Name = "The Protege", Cost = 2}
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
