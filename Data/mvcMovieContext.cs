using Microsoft.EntityFrameworkCore;
using mvcMovie.Models;

namespace mvcMovie.Data
{
    public class mvcMovieContext : DbContext
    {
        public mvcMovieContext (DbContextOptions<mvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}