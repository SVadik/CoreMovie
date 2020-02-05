using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMovie.Models;

namespace CoreMovie.Data
{
    public class CoreMovieContext : DbContext
    {
        public CoreMovieContext (DbContextOptions<CoreMovieContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMovie.Models.Movie> Movie { get; set; }
    }
}
