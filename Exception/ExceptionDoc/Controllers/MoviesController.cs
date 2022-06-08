using ExceptionDoc.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieData _movieData;

        public MoviesController(IMovieData movieData)
        {
            _movieData = movieData;
        }
        //Standart Kullanım

        [HttpGet]
        public IActionResult GetMovies()
        {
            return NotFound();
        }
    }
}
