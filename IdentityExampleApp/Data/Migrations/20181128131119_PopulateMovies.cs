using IdentityExampleApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityExampleApp.Data.Migrations
{
    public partial class PopulateMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Comedy\", {MovieGenre.Comedy})");
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Action\", {MovieGenre.Action})");
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Family\", {MovieGenre.Family})");
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Romance\", {MovieGenre.Romance})");
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Suspense\", {MovieGenre.Suspense})");
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Documentary\", {MovieGenre.Documentary})");
            migrationBuilder.Sql($"INSERT INTO MovieGenres (MovieGenreName, MovieGenreId) VALUES(\"Drama\", {MovieGenre.Drama})");

            migrationBuilder.Sql($"INSERT INTO MpaRatings (MpaRatingName, MpaRatingId) VALUES(\"G\", {MpaRating.G})");
            migrationBuilder.Sql($"INSERT INTO MpaRatings (MpaRatingName, MpaRatingId) VALUES(\"PG\", {MpaRating.PG})");
            migrationBuilder.Sql($"INSERT INTO MpaRatings (MpaRatingName, MpaRatingId) VALUES(\"PG-13\", {MpaRating.PG13})");
            migrationBuilder.Sql($"INSERT INTO MpaRatings (MpaRatingName, MpaRatingId) VALUES(\"R\", {MpaRating.R})");
            migrationBuilder.Sql($"INSERT INTO MpaRatings (MpaRatingName, MpaRatingId) VALUES(\"X\", {MpaRating.X})");
            migrationBuilder.Sql($"INSERT INTO MpaRatings (MpaRatingName, MpaRatingId) VALUES(\"NR\", {MpaRating.NR})");

            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Shrek\", 2001, {MovieGenre.Family}, {MpaRating.PG}, '2018-10-27', 1)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Wall-e\", 2008, {MovieGenre.Family}, {MpaRating.G}, '2018-10-27', 2)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Summer Rental\",1985, {MovieGenre.Comedy}, {MpaRating.PG}, '2018-10-27', 3)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Apollo 13\", 1995, {MovieGenre.Suspense}, {MpaRating.PG}, '2018-10-27', 4)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"The Hangover\", 2009, {MovieGenre.Comedy}, {MpaRating.R}, '2018-10-27', 5)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Die Hard\", 1988, {MovieGenre.Action}, {MpaRating.R}, '2018-10-27', 6)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Toy Story\", 1995, {MovieGenre.Family}, {MpaRating.PG}, '2018-10-27', 7)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Titanic\", 1997, {MovieGenre.Romance}, {MpaRating.PG13}, '2018-10-27', 8)");
            migrationBuilder.Sql($"INSERT INTO Movies (Title, Year, MovieGenreId, MpaRatingId, DateAdded, MovieId) VALUES(\"Uncle Buck\", 1989, {MovieGenre.Comedy}, {MpaRating.PG}, '2018-10-27', 9)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
