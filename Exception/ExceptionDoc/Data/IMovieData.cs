using ExceptionDoc.Entities.Concrete;

namespace ExceptionDoc.Data
{
    public interface IMovieData
    {
        List<Movie> GetMovies();
    }
}