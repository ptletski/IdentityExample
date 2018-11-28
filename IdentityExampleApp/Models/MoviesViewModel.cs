using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IdentityExampleApp.Data;
using Microsoft.EntityFrameworkCore;

namespace IdentityExampleApp.Models
{
    public class MoviesViewModel : IDisposable
    {
        protected ApplicationDbContext _dbContext;

        public MoviesViewModel()
        {
            InitializeDbContext();
        }

        private void InitializeDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=IdentityExample.db");

            _dbContext = new ApplicationDbContext(optionsBuilder.Options);
        }

        public IEnumerable<Movie> Movies => _dbContext.Movies;

        public bool IsAny
        {
            get
            {
                bool isAny = false;

                try
                {
                    isAny = Movies.ToList().Any();
                }
                catch (Exception e)
                {
                    Debug.Assert(false, "Could Not Perform IsAny Check on Movies");
                    Debug.Assert(false, e.Message);
                }

                return isAny;
            }
        }

        public Movie Find(int id)
        {
            Movie movie = null;

            try
            {
                movie = _dbContext.Movies.SingleOrDefault(m => m.MovieId == id);
            }
            catch (Exception e)
            {
                Debug.Assert(false, "Failure Finding Movie by Id");
                Debug.Assert(false, e.Message);
            }

            return movie;
        }

        public string GetGenreName(Movie movie)
        {
            string name = "";

            try
            {
                byte genreId = movie.MovieGenreId;
                name = _dbContext.MovieGenres.Find(genreId).MovieGenreName;
            }
            catch (Exception e)
            {
                Debug.Assert(false, "Failure Finding MovieGenres");
                Debug.Assert(false, e.Message);
            }

            return name;
        }


        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
