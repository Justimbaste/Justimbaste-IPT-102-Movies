using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

public class MoviesController : Controller
{
    public IActionResult Movies()
    {
        MovieViewModel movie = new MovieViewModel
        {
            Id = 1,
            Name = "Bird Box",
            Image = "~/css/images/movie.1.jpeg",
            Description = "Bird Box Barcelona is a 2023 Spanish post-apocalyptic horror thriller film directed and written by Álex and David Pastor. A spin-off sequel to the 2018 film Bird Box, adapted from Josh Malerman's 2014 novel of the same name, it was released on Netflix on July 14, 2023 to mixed reviews.",
            WikipediaLink = "https://en.wikipedia.org/wiki/Bird_Box_Barcelona"

        }; 

        return View(movie);
    } 
}
