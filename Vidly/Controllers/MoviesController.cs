using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> moviesList = new List<Movie>
        {
            new Movie {Id = 1, Name = "Shrek"},
            new Movie {Id = 2, Name = "Wall-e"}
        };


        //this will be called when we go to Movies/Random
        //IActionResult is just data that we will return such as JSON 
        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = moviesList;
            return Ok(movies);
        }
        //HTTP request to api/movies/{id} route. Providing id after movies
        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            return Ok(id);

        }

        //HTTP request to api/movies/{year}/{moth} ro ute, provide these two values
        //apply constraint to month, has to be 2 numbers
        [HttpGet("{year}/{month:range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            
            return Content(year+"/"+month);
        }
    }
}
