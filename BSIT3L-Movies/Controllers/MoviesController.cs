using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Movies()
        {
            return View();
        }
    }
}
