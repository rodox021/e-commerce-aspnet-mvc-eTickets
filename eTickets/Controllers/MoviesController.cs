using eTickets.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        public readonly MoviesServices _moviesServices;

        public MoviesController(MoviesServices moviesServices)
        {
            _moviesServices = moviesServices;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _moviesServices.FindAllAsync();
            return View(allMovies);
        }
    }
}
