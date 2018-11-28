using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExampleApp.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public byte MpaRatingId { get; set; }
        public byte MovieGenreId { get; set; }
        public DateTime DateAdded { get; set; }

        [Key]
        public int MovieId { get; set; }
    }
}
