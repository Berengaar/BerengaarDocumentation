using ExceptionDoc.Entities.Concrete;

namespace ExceptionDoc.Data
{
    public class MovieData : IMovieData
    {
        private static readonly List<Movie> _movies;
        public MovieData()
        {
            _movies.Add(new Movie { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Date = DateTime.Now, Name = "Movie1", Subject = "Action" });
            _movies.Add(new Movie { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Date = DateTime.Now, Name = "Movie2", Subject = "Comedy" });
            _movies.Add(new Movie { Id = Guid.NewGuid(), AddedDate = DateTime.Now, Date = DateTime.Now, Name = "Movie3", Subject = "Romantic" });
        }
        public List<Movie> GetMovies() => _movies;

    }
}
