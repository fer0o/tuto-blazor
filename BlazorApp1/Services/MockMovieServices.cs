using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public static class MockMovieService
    {
        public static List<MovieCard> GetMovies()
        {
            return new List<MovieCard>
            {
                new MovieCard
                {
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Description = "A thief who steals corporate secrets through dream-sharing technology.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_QL75_UX190_CR0,0,190,281_.jpg"
                },
                new MovieCard
                {
                    Title = "The Matrix",
                    Year = 1999,
                    Director = "The Wachowskis",
                    Description = "A hacker discovers reality is a simulation and joins a rebellion.",
                    ImageUrl = "https://image.tmdb.org/t/p/w500/aOIuZAjPaRIE6CMzbazvcHuHXDc.jpg"
                },
                new MovieCard
                {
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Description = "A team of explorers travel through a wormhole in space.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard
                {
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Director = "Frank Darabont",
                    Description = "Two imprisoned",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                }
            };
        }
    }
}
