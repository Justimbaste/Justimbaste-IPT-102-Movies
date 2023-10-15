using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
           new MovieViewModel { Id = 1, Name = "BIRD BOX", Rating = "1", Image = "css/images/movie.1.jpg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 2, Name = "BALLERINA", Rating = "5", Image = "css/images/movie.2.jpg", Teaser = "https://www.youtube.com/watch?v=IhXfUTGVEUI" },
           new MovieViewModel { Id = 3, Name = "SPIDER MAN 3", Rating = "10", Image = "css/images/movie3.jpg", Teaser = "https://www.youtube.com/watch?v=e5wUilOeOmg" },
           new MovieViewModel { Id = 4, Name = "JOHN WICK 4", Rating = "4", Image = "css/images/movie.3.jpeg", Teaser = "https://www.youtube.com/watch?v=Tsn6bBtUaLI" },
           new MovieViewModel { Id = 5, Name = "NOWHERE", Rating = "7", Image = "css/images/movie.4.jpeg", Teaser = "https://www.youtube.com/watch?v=KDUtdcU10YA" },
           new MovieViewModel { Id = 6, Name = "THE NUN II", Rating = "3", Image = "css/images/movies.5.jpeg", Teaser = "https://www.youtube.com/watch?v=QF-oyCwaArU" },
           new MovieViewModel { Id = 7, Name = "AQUAMAN 2", Rating = "2", Image = "css/images/movie.6.jpeg", Teaser = "\"https://www.youtube.com/watch?v=_AqlTRg2IY8" },
           new MovieViewModel { Id = 8, Name = "HEART OF STONE", Rating = "8", Image = "css/images/mov1.jpeg", Teaser = "https://www.youtube.com/watch?v=XuDwndGaCFo" },
           new MovieViewModel { Id = 9, Name = "THE POPE'S EXORCIST", Rating = "5", Image = "css/images/movie.7.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 10, Name = "EXTRACTION 2", Rating = "11", Image = "css/images/mov2.jpg", Teaser = "https://www.youtube.com/watch?v=YJXqvnT_rsk" },
           new MovieViewModel { Id = 11, Name = "KILL BOKSOON", Rating = "15", Image = "css/images/mov3.jpeg", Teaser = "https://www.youtube.com/watch?v=Y274jZs5s7s" },
           new MovieViewModel { Id = 12, Name = "HUNGER", Rating = "16", Image = "css/images/mov4.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 13, Name = "EVIL DEAD RISE", Rating = "18", Image = "css/images/mov5.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 14, Name = "INSIDOUS", Rating = "6", Image = "css/images/mov6.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 15, Name = "BARBIE", Rating = "12", Image = "css/images/mov7.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 16, Name = "JUNG_E", Rating = "14", Image = "css/images/mov8.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 17, Name = "UNLOCKED", Rating = "9", Image = "css/images/mov9.jpeg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },
           new MovieViewModel { Id = 18, Name = "DELETER", Rating = "13", Image = "css/images/mov10.jpg", Teaser = "https://www.youtube.com/watch?v=lT4EY1i6ZDs" },

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

