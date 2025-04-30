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
                    Genre = "Sci-Fi",
                    Director = "Christopher Nolan",
                    Description = "A thief who steals corporate secrets through dream-sharing technology.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_QL75_UX190_CR0,0,190,281_.jpg"
                },
                new MovieCard
                {
                    Title = "The Matrix",
                    Year = 1999,
                    Genre = "Action",
                    Director = "The Wachowskis",
                    Description = "A hacker discovers reality is a simulation and joins a rebellion.",
                    ImageUrl = "https://image.tmdb.org/t/p/w500/aOIuZAjPaRIE6CMzbazvcHuHXDc.jpg"
                },
                new MovieCard
                {
                    Title = "Interstellar",
                    Year = 2014,
                    Genre = "Adventure",
                    Director = "Christopher Nolan",
                    Description = "A team of explorers travel through a wormhole in space.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard
                {
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Genre = "Drama",
                    Director = "Frank Darabont",
                    Description = "Two imprisoned",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard
                {
                    Title = "The Godfather",
                    Year = 1972,
                    Genre = "Crime",
                    Director = "Francis Ford Coppola",
                    Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard {
                    Title = "Chuckie",
                    Year = 2023,
                    Genre = "Horror",
                    Director = "Don Mancini",
                    Description = "A series of murders in a small town lead to the discovery of a killer doll.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTc2M2FjMDMtYzBmNS00ODMxLWJjOTYtZmNkMDYxMTU5ZTBhXkEyXkFqcGc@._V1_.jpg"
                },
                new MovieCard {
                    Title = "The Conjuring",
                    Year = 2013,
                    Genre = "Horror",
                    Director = "James Wan",
                    Description = "Paranormal investigators work to help a family terrorized by a dark presence.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWQyNTQwNTAtZDE2Yy00NjlhLWE4N2YtYjBkYTM4ZmM3ZDk0XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard {
                    Title = "A Nightmare on Elm Street",
                    Year = 1984,
                    Genre = "Horror",
                    Director = "Wes Craven",
                    Description = "A group of teenagers are stalked by a serial killer who attacks them in their dreams.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZmN2VlMWMtMTdlMi00NDBhLWIyODMtODEwMzM0ODMwMWYwXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard {
                    Title = "The Exorcist",
                    Year = 1973,
                    Genre = "Horror",
                    Director = "William Friedkin",
                    Description = "A mother seeks the help of two priests to rid her daughter of a demonic possession.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjg3YjE4ZjAtYTdmYS00ZTBkLWE1ZjgtNzAzODUwNzRiYjlmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard {
                    Title = "The Shining",
                    Year = 1980,
                    Genre = "Horror",
                    Director = "Stanley Kubrick",
                    Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father.",
                    ImageUrl = "https://m.media-amazon.com/images/I/81f0R7uwewL._AC_UF894,1000_QL80_.jpg"
                },
                new MovieCard {
                    Title = "Toy Story",
                    Year = 1995,
                    Genre = "Animation",
                    Director = "John Lasseter",
                    Description = "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTA3OWVjOWItNjE1NS00NzZiLWE1MjgtZDZhMWI1ZTlkNzYwXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new MovieCard {
                    Title = "Finding Nemo",
                    Year = 2003,
                    Genre = "Animation",
                    Director = "Andrew Stanton",
                    Description = "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5NjExNTA5OV5BMl5BanBnXkFtZTYwMTQ0ODY2._V1_.jpg"
                },
                new MovieCard {
                    Title = "The Lion King",
                    Year = 1994,
                    Genre = "Animation",
                    Director = "Roger Allers, Rob Minkoff",
                    Description = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGI3N2ZkZjctYjM3Yy00YjFkLThlMDYtOWY3ZWU0MDYzZDY1XkEyXkFqcGc@._V1_.jpg"
                },
                new MovieCard {
                    Title = "Frozen",
                    Year = 2013,
                    Genre = "Animation",
                    Director = "Chris Buck, Jennifer Lee",
                    Description = "When their kingdom becomes trapped in an eternal winter, fearless Anna sets off on a journey alongside a rugged iceman, his loyal reindeer, and a naive snowman to find her sister Elsa.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ1MjQwMTE5OF5BMl5BanBnXkFtZTgwNjk3MTcyMDE@._V1_.jpg"
                },
                new MovieCard {
                    Title = "Zootopia",
                    Year = 2016,
                    Genre = "Animation",
                    Director = "Byron Howard, Rich Moore",
                    Description = "In a city of anthropomorphic animals, a bunny cop and a cynical con artist fox must work together to uncover a conspiracy.",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTMyMjEyNzIzMV5BMl5BanBnXkFtZTgwNzIyNjU0NzE@._V1_FMjpg_UX1000_.jpg"
                }
            };
        }
    }
}
