using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;


namespace Vidly.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        //this will be called when we go to Movies/Random
        //IActionResult is just data that we will return such as JSON 
        [HttpGet]
        public IActionResult GetMovies()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Shrek"
            };
            return Ok(movie);
        }
        //HTTP request to api/movies/{id} route. Providing id after movies
        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            return Ok(id);

        }

        //HTTP request to api/movies/{year}/{moth} route, provide these two values
        [HttpGet("{year}/{month}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }
    }
}
