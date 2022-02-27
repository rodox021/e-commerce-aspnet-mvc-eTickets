using eTickets.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        public readonly ActorsServices _actorsService;

        public ActorsController(ActorsServices actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _actorsService.FindAllAsync();
            return View(actors);
        }
    }
}
