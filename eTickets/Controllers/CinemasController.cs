using eTickets.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly CinemasServices _cinemasController;

        public CinemasController(CinemasServices cinemasController)
        {
            _cinemasController = cinemasController;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
