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
        public IActionResult GetMovies()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Shrek"
            };
            return Ok(movie);
        }
    }
}
